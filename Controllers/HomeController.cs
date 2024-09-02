using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RDLC_with_Entity_FrameWork.Models;
using System.Data;
using System.Diagnostics;

namespace RDLC_with_Entity_FrameWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly KhalidRashid2223Context _context;

        public HomeController(ILogger<HomeController> logger,IWebHostEnvironment webHostEnvironment,KhalidRashid2223Context context)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
          _context = context;
        }

        public DataTable GetData()
        {
            var data = _context.AcctVoucherChildren
                         .Select(e => new
                         {
                             e.VoucherNo,
                             e.VoucherType,
                             e.Site,
                             e.VoucherMonth,
                             e.AccountCode,
                         })
                         .ToList();

            foreach (var item in data)
            {
                _logger.LogInformation($"VoucherNo: {item.VoucherNo}, VoucherType: {item.VoucherType}, Site: {item.Site}, VoucherMonth: {item.VoucherMonth}, AccountCode: {item.AccountCode}");
            }


            DataTable dt = new DataTable();
            dt.Columns.Add("Voucher_No", typeof(int));
            dt.Columns.Add("Voucher_Type", typeof(string));
            dt.Columns.Add("Site", typeof(string));
            dt.Columns.Add("Voucher_Month", typeof(int));
            dt.Columns.Add("Account_Code", typeof(string));

            foreach (var item in data)
            {
                dt.Rows.Add(item.VoucherNo, item.VoucherType, item.Site, item.VoucherMonth,item.AccountCode);
            }

            return dt;
        }
        public IActionResult GenerateReport()
    {
        string mimetype = "";
        int extension = 1;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "VoucherChild.rdlc");

            var report = new LocalReport(path);
        report.AddDataSource("VoucherChild", GetData());

        var result = report.Execute(RenderType.Pdf, extension, null, mimetype);

        return File(result.MainStream, "application/pdf");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
