using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class KhalidRashid2223Context : DbContext
{
    public KhalidRashid2223Context()
    {
    }

    public KhalidRashid2223Context(DbContextOptions<KhalidRashid2223Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AcctChartOfAccount> AcctChartOfAccounts { get; set; }

    public virtual DbSet<AcctCity> AcctCities { get; set; }

    public virtual DbSet<AcctInvoiceChild> AcctInvoiceChildren { get; set; }

    public virtual DbSet<AcctInvoiceMaster> AcctInvoiceMasters { get; set; }

    public virtual DbSet<AcctOpeningBalance> AcctOpeningBalances { get; set; }

    public virtual DbSet<AcctOrder> AcctOrders { get; set; }

    public virtual DbSet<AcctViewAccountBalance> AcctViewAccountBalances { get; set; }

    public virtual DbSet<AcctViewAccountTotal> AcctViewAccountTotals { get; set; }

    public virtual DbSet<AcctViewCharOfAccount> AcctViewCharOfAccounts { get; set; }

    public virtual DbSet<AcctViewInvoice> AcctViewInvoices { get; set; }

    public virtual DbSet<AcctViewOpeningTrial> AcctViewOpeningTrials { get; set; }

    public virtual DbSet<AcctViewVoucher> AcctViewVouchers { get; set; }

    public virtual DbSet<AcctVoucherChild> AcctVoucherChildren { get; set; }

    public virtual DbSet<AcctVoucherDeleted> AcctVoucherDeleteds { get; set; }

    public virtual DbSet<AcctVoucherMaster> AcctVoucherMasters { get; set; }

    public virtual DbSet<AcctVoucherScanDocument> AcctVoucherScanDocuments { get; set; }

    public virtual DbSet<AcctVoucherType> AcctVoucherTypes { get; set; }

    public virtual DbSet<InvDemandChild> InvDemandChildren { get; set; }

    public virtual DbSet<InvDemandMaster> InvDemandMasters { get; set; }

    public virtual DbSet<InvDepartment> InvDepartments { get; set; }

    public virtual DbSet<InvIgpchild> InvIgpchildren { get; set; }

    public virtual DbSet<InvIgpmaster> InvIgpmasters { get; set; }

    public virtual DbSet<InvItemCoding> InvItemCodings { get; set; }

    public virtual DbSet<InvItemLocation> InvItemLocations { get; set; }

    public virtual DbSet<InvOgpchild> InvOgpchildren { get; set; }

    public virtual DbSet<InvOgpmaster> InvOgpmasters { get; set; }

    public virtual DbSet<InvOpeningBalance> InvOpeningBalances { get; set; }

    public virtual DbSet<InvPurchaseOrderChild> InvPurchaseOrderChildren { get; set; }

    public virtual DbSet<InvPurchaseOrderMaster> InvPurchaseOrderMasters { get; set; }

    public virtual DbSet<InvQuotationChild> InvQuotationChildren { get; set; }

    public virtual DbSet<InvQuotationMaster> InvQuotationMasters { get; set; }

    public virtual DbSet<InvStoreChild> InvStoreChildren { get; set; }

    public virtual DbSet<InvStoreLocation> InvStoreLocations { get; set; }

    public virtual DbSet<InvStoreMaster> InvStoreMasters { get; set; }

    public virtual DbSet<InvViewDemand> InvViewDemands { get; set; }

    public virtual DbSet<InvViewDepartment> InvViewDepartments { get; set; }

    public virtual DbSet<InvViewIgp> InvViewIgps { get; set; }

    public virtual DbSet<InvViewItemDetail> InvViewItemDetails { get; set; }

    public virtual DbSet<InvViewItemOpening> InvViewItemOpenings { get; set; }

    public virtual DbSet<InvViewLocation> InvViewLocations { get; set; }

    public virtual DbSet<InvViewOgp> InvViewOgps { get; set; }

    public virtual DbSet<InvViewPendingDemand> InvViewPendingDemands { get; set; }

    public virtual DbSet<InvViewPurchaseOrder> InvViewPurchaseOrders { get; set; }

    public virtual DbSet<InvViewQuotation> InvViewQuotations { get; set; }

    public virtual DbSet<InvViewStoreIssue> InvViewStoreIssues { get; set; }

    public virtual DbSet<InvViewStoreReceive> InvViewStoreReceives { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcctChartOfAccount>(entity =>
        {
            entity.HasKey(e => new { e.AccountCode, e.Site });

            entity.ToTable("ACCT_ChartOfAccount");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.BalanceSheet)
                .HasDefaultValue(false)
                .HasColumnName("Balance_Sheet");
            entity.Property(e => e.BankCode)
                .HasDefaultValue(false)
                .HasColumnName("Bank_Code");
            entity.Property(e => e.Budget).HasDefaultValue(false);
            entity.Property(e => e.CarryForward)
                .HasDefaultValue(false)
                .HasColumnName("Carry_Forward");
            entity.Property(e => e.CashCode)
                .HasDefaultValue(false)
                .HasColumnName("Cash_Code");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.Cnic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IncomeTaxPercent)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("IncomeTax_Percent");
            entity.Property(e => e.IncomeTaxStatus)
                .HasDefaultValue(false)
                .HasColumnName("IncomeTax_Status");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Mobile_No");
            entity.Property(e => e.Ntn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.Payable).HasDefaultValue(false);
            entity.Property(e => e.PaymentStop)
                .HasDefaultValue(false)
                .HasColumnName("Payment_Stop");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProfitLoss)
                .HasDefaultValue(false)
                .HasColumnName("Profit_Loss");
            entity.Property(e => e.Receivable).HasDefaultValue(false);
            entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.Stn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STN");
        });

        modelBuilder.Entity<AcctCity>(entity =>
        {
            entity.HasKey(e => new { e.CityId, e.Site });

            entity.ToTable("ACCT_Cities");

            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
        });

        modelBuilder.Entity<AcctInvoiceChild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("ACCT_InvoiceChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.AfterDiscountAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AfterDiscount_Amount");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.FurtherTaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FurtherTax_Amount");
            entity.Property(e => e.FurtherTaxPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FurtherTax_Percent");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.IssueQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Code");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ReceiveQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Receive_Qty");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AcctInvoiceMaster).WithMany(p => p.AcctInvoiceChildren)
                .HasForeignKey(d => new { d.TransactionNo, d.Site, d.TransactionType })
                .HasConstraintName("FK_ACCT_InvoiceChild_ACCT_InvoiceMaster");
        });

        modelBuilder.Entity<AcctInvoiceMaster>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.Site, e.TransactionType });

            entity.ToTable("ACCT_InvoiceMaster");

            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Approved_By");
            entity.Property(e => e.ApprovedTime)
                .HasColumnType("datetime")
                .HasColumnName("Approved_Time");
            entity.Property(e => e.Checked).HasDefaultValue(false);
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Checked_By");
            entity.Property(e => e.CheckedTime)
                .HasColumnType("datetime")
                .HasColumnName("Checked_Time");
            entity.Property(e => e.DcDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DC_No");
            entity.Property(e => e.DcReturnNo)
                .HasDefaultValue(0)
                .HasColumnName("DC_ReturnNo");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.GrossAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.InvoiceNo).HasColumnName("Invoice_No");
            entity.Property(e => e.NetAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.SaleOrderNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SaleOrder_No");
            entity.Property(e => e.TermsConditions)
                .IsUnicode(false)
                .HasColumnName("Terms_Conditions");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Transaction_Date");
        });

        modelBuilder.Entity<AcctOpeningBalance>(entity =>
        {
            entity.HasKey(e => new { e.AccountCode, e.Site }).HasName("PK_ACCT_OpeningBalance_1");

            entity.ToTable("ACCT_OpeningBalance");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Opening_Balance");
        });

        modelBuilder.Entity<AcctOrder>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.Site });

            entity.ToTable("ACCT_Order");

            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.OrderDetail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Order_Detail");
        });

        modelBuilder.Entity<AcctViewAccountBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ACCT_View_AccountBalance");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.CarryForward).HasColumnName("Carry_Forward");
            entity.Property(e => e.ControlAccount)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Control_Account");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Opening_Balance");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalCredit).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalDebit).HasColumnType("numeric(38, 2)");
        });

        modelBuilder.Entity<AcctViewAccountTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ACCT_View_AccountTotal");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.CarryForward).HasColumnName("Carry_Forward");
            entity.Property(e => e.ControlAccount)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Control_Account");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.MainAccount)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Main_Account");
            entity.Property(e => e.MainDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Main_Description");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Opening_Balance");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmainAccount)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Submain_Account");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
            entity.Property(e => e.TotalCredit).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalDebit).HasColumnType("numeric(38, 2)");
        });

        modelBuilder.Entity<AcctViewCharOfAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ACCT_View_CharOfAccount");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.BalanceSheet).HasColumnName("Balance_Sheet");
            entity.Property(e => e.BankCode).HasColumnName("Bank_Code");
            entity.Property(e => e.CarryForward).HasColumnName("Carry_Forward");
            entity.Property(e => e.CashCode).HasColumnName("Cash_Code");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.Cnic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.ControlAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Control_Account");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IncomeTaxPercent)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("IncomeTax_Percent");
            entity.Property(e => e.IncomeTaxStatus).HasColumnName("IncomeTax_Status");
            entity.Property(e => e.MainAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Main_Account");
            entity.Property(e => e.MainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Description");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mobile_No");
            entity.Property(e => e.Ntn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.PaymentStop).HasColumnName("Payment_Stop");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProfitLoss).HasColumnName("Profit_Loss");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");
            entity.Property(e => e.Stn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STN");
            entity.Property(e => e.SubmainAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Submain_Account");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
        });

        modelBuilder.Entity<AcctViewInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ACCT_View_Invoice");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.AfterDiscountAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AfterDiscount_Amount");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Approved_By");
            entity.Property(e => e.ApprovedTime)
                .HasColumnType("datetime")
                .HasColumnName("Approved_Time");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Checked_By");
            entity.Property(e => e.CheckedTime)
                .HasColumnType("datetime")
                .HasColumnName("Checked_Time");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.Cnic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.ControlCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Control_Code");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.DcDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DC_No");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.FurtherTaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FurtherTax_Amount");
            entity.Property(e => e.FurtherTaxPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FurtherTax_Percent");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.InvoiceNo).HasColumnName("Invoice_No");
            entity.Property(e => e.IssueQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mobile_No");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.Ntn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ReceiveQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Receive_Qty");
            entity.Property(e => e.SaleOrderNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SaleOrder_No");
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STN");
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
            entity.Property(e => e.TermsConditions)
                .IsUnicode(false)
                .HasColumnName("Terms_Conditions");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Transaction_Date");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AcctViewOpeningTrial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ACCT_View_OpeningTrial");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.CarryForward).HasColumnName("Carry_Forward");
            entity.Property(e => e.ControlAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Control_Account");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.MainAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Main_Account");
            entity.Property(e => e.MainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Description");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Opening_Balance");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmainAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Submain_Account");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
        });

        modelBuilder.Entity<AcctViewVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ACCT_View_Voucher");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Approved_By");
            entity.Property(e => e.ApprovedTime)
                .HasColumnType("datetime")
                .HasColumnName("Approved_Time");
            entity.Property(e => e.BalanceSheet).HasColumnName("Balance_Sheet");
            entity.Property(e => e.BankCode).HasColumnName("Bank_Code");
            entity.Property(e => e.BankReconciliation).HasColumnName("Bank_Reconciliation");
            entity.Property(e => e.CarryForward).HasColumnName("Carry_Forward");
            entity.Property(e => e.CashCode).HasColumnName("Cash_Code");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Checked_By");
            entity.Property(e => e.CheckedTime)
                .HasColumnType("datetime")
                .HasColumnName("Checked_Time");
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Cheque_Date");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cheque_No");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.Cnic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.ControlAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Control_Account");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditStatus).HasColumnName("Credit_Status");
            entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IncomeTaxPercent)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("IncomeTax_Percent");
            entity.Property(e => e.IncomeTaxStatus).HasColumnName("IncomeTax_Status");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Invoice_No");
            entity.Property(e => e.MainAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Main_Account");
            entity.Property(e => e.MainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Description");
            entity.Property(e => e.Mark)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MobileNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mobile_No");
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Ntn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.PdcVoucher).HasColumnName("PDC_Voucher");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProfitLoss).HasColumnName("Profit_Loss");
            entity.Property(e => e.ReconciliationDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Reconciliation_Date");
            entity.Property(e => e.RecordNo).HasColumnName("Record_No");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STN");
            entity.Property(e => e.SubmainAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Submain_Account");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Vendor_Code");
            entity.Property(e => e.VoucherDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Voucher_Date");
            entity.Property(e => e.VoucherDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Voucher_Description");
            entity.Property(e => e.VoucherMonth).HasColumnName("Voucher_Month");
            entity.Property(e => e.VoucherNo).HasColumnName("Voucher_No");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Voucher_Type");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WorkOrder_No");
        });

        modelBuilder.Entity<AcctVoucherChild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("ACCT_Voucher_Child");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.BankReconciliation)
                .HasDefaultValue(false)
                .HasColumnName("Bank_Reconciliation");
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Cheque_Date");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Cheque_No");
            entity.Property(e => e.Credit)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditStatus)
                .HasDefaultValue(false)
                .HasColumnName("Credit_Status");
            entity.Property(e => e.Debit)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Invoice_No");
            entity.Property(e => e.Mark)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength();
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProjectCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Project_Code");
            entity.Property(e => e.ReconciliationDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("smalldatetime")
                .HasColumnName("Reconciliation_Date");
            entity.Property(e => e.RecordNo)
                .HasDefaultValue(0)
                .HasColumnName("Record_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Vendor_Code");
            entity.Property(e => e.VoucherMonth).HasColumnName("Voucher_Month");
            entity.Property(e => e.VoucherNo).HasColumnName("Voucher_No");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Voucher_Type");

            //entity.HasOne(d => d.AcctVoucherMaster).WithMany(p => p.AcctVoucherChildren)
            //    .HasForeignKey(d => new { d.VoucherNo, d.VoucherType, d.Site, d.VoucherMonth })
            //    .HasConstraintName("FK_ACCT_Voucher_Child_ACCT_Voucher_Master");
        });

        modelBuilder.Entity<AcctVoucherDeleted>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("ACCT_Voucher_Deleted");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherDate)
                .HasColumnType("datetime")
                .HasColumnName("Voucher_Date");
            entity.Property(e => e.VoucherMonth).HasColumnName("Voucher_Month");
            entity.Property(e => e.VoucherNo).HasColumnName("Voucher_No");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Voucher_Type");
        });

        modelBuilder.Entity<AcctVoucherMaster>(entity =>
        {
            entity.HasKey(e => new { e.VoucherNo, e.VoucherType, e.Site, e.VoucherMonth });

            entity.ToTable("ACCT_Voucher_Master");

            entity.Property(e => e.VoucherNo).HasColumnName("Voucher_No");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Voucher_Type");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherMonth).HasColumnName("Voucher_Month");
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Approved_By");
            entity.Property(e => e.ApprovedTime)
                .HasColumnType("datetime")
                .HasColumnName("Approved_Time");
            entity.Property(e => e.Checked).HasDefaultValue(false);
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Checked_By");
            entity.Property(e => e.CheckedTime)
                .HasColumnType("datetime")
                .HasColumnName("Checked_Time");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.PdcVoucher)
                .HasDefaultValue(false)
                .HasColumnName("PDC_Voucher");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.VoucherDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Voucher_Date");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WorkOrder_No");
        });

        modelBuilder.Entity<AcctVoucherScanDocument>(entity =>
        {
            entity.HasKey(e => new { e.DocumentNo, e.VoucherNo, e.VoucherType, e.Site, e.VoucherMonth });

            entity.ToTable("ACCT_Voucher_ScanDocuments");

            entity.Property(e => e.DocumentNo).HasColumnName("Document_No");
            entity.Property(e => e.VoucherNo).HasColumnName("Voucher_No");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Voucher_Type");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherMonth).HasColumnName("Voucher_Month");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ScanDocument)
                .HasColumnType("image")
                .HasColumnName("Scan_Document");
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
        });

        modelBuilder.Entity<AcctVoucherType>(entity =>
        {
            entity.HasKey(e => new { e.VoucherId, e.Site });

            entity.ToTable("ACCT_Voucher_Types");

            entity.Property(e => e.VoucherId).HasColumnName("Voucher_ID");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.VoucherDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Voucher_Description");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Voucher_Type");
        });

        modelBuilder.Entity<InvDemandChild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("INV_DemandChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.BalanceQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Qty");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.DemandQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Demand_Qty");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Code");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RequiredQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Required_Qty");
            entity.Property(e => e.RowNo)
                .HasDefaultValue(0)
                .HasColumnName("Row_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");

            entity.HasOne(d => d.InvDemandMaster).WithMany(p => p.InvDemandChildren)
                .HasForeignKey(d => new { d.DemandNo, d.Site })
                .HasConstraintName("FK_INV_DemandChild_INV_DemandMaster");
        });

        modelBuilder.Entity<InvDemandMaster>(entity =>
        {
            entity.HasKey(e => new { e.DemandNo, e.Site }).HasName("PK_INV_DemandMaster_1");

            entity.ToTable("INV_DemandMaster");

            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.DemandDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("smalldatetime")
                .HasColumnName("Demand_Date");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Department_Code");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
        });

        modelBuilder.Entity<InvDepartment>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentCode, e.Site });

            entity.ToTable("INV_Department");

            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
        });

        modelBuilder.Entity<InvIgpchild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("INV_IGPChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.GrnStatus).HasColumnName("GRN_Status");
            entity.Property(e => e.IgpNo).HasColumnName("IGP_No");
            entity.Property(e => e.IgpQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IGP_Qty");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.RemarksChild)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Remarks_Child");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvIgpmaster>(entity =>
        {
            entity.HasKey(e => new { e.IgpNo, e.Site }).HasName("PK_INV_IGPMaster_1");

            entity.ToTable("INV_IGPMaster");

            entity.Property(e => e.IgpNo).HasColumnName("IGP_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.DcDate)
                .HasColumnType("datetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DC_No");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.IgpDate)
                .HasColumnType("datetime")
                .HasColumnName("IGP_Date");
            entity.Property(e => e.IgpType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IGP_Type");
            entity.Property(e => e.ManualIgpDate)
                .HasColumnType("datetime")
                .HasColumnName("Manual_IGP_Date");
            entity.Property(e => e.ManualIgpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Manual_IGP_No");
            entity.Property(e => e.PoDate)
                .HasColumnType("datetime")
                .HasColumnName("PO_Date");
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PO_No");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SecurityGuard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Security_Guard");
            entity.Property(e => e.StoreLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Location");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WorkOrder_No");
        });

        modelBuilder.Entity<InvItemCoding>(entity =>
        {
            entity.HasKey(e => new { e.ItemCode, e.Site });

            entity.ToTable("INV_ItemCoding");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemMaximumQty).HasColumnName("Item_MaximumQty");
            entity.Property(e => e.ItemMinimumQty).HasColumnName("Item_MinimumQty");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemReOrderLevel).HasColumnName("Item_ReOrderLevel");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Item_Unit");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Location_Code");
            entity.Property(e => e.LocationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Location_Name");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Parent_Code");
            entity.Property(e => e.Status).HasDefaultValue(false);
        });

        modelBuilder.Entity<InvItemLocation>(entity =>
        {
            entity.HasKey(e => new { e.LocationCode, e.Site });

            entity.ToTable("INV_ItemLocations");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Location_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Location_Name");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
        });

        modelBuilder.Entity<InvOgpchild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("INV_OGPChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.OgpNo).HasColumnName("OGP_No");
            entity.Property(e => e.OgpQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OGP_Qty");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvOgpmaster>(entity =>
        {
            entity.HasKey(e => new { e.OgpNo, e.Site }).HasName("PK_INV_OGPMaster_1");

            entity.ToTable("INV_OGPMaster");

            entity.Property(e => e.OgpNo).HasColumnName("OGP_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_ID");
            entity.Property(e => e.Driver)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.OgpDate)
                .HasColumnType("datetime")
                .HasColumnName("OGP_Date");
            entity.Property(e => e.OgpType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OGP_Type");
            entity.Property(e => e.StoreLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Location");
            entity.Property(e => e.Through)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvOpeningBalance>(entity =>
        {
            entity.HasKey(e => new { e.ItemCode, e.Site }).HasName("PK_INV_OpeningBalance_1");

            entity.ToTable("INV_OpeningBalance");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ItemOpeningQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Item_OpeningQty");
            entity.Property(e => e.ItemOpeningRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Item_OpeningRate");
            entity.Property(e => e.ItemOpeningValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Item_OpeningValue");
        });

        modelBuilder.Entity<InvPurchaseOrderChild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("INV_PurchaseOrderChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.DemandSerialNo).HasColumnName("Demand_SerialNo");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.IgpStatus).HasColumnName("IGP_Status");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.PoQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PO_Quantity");
            entity.Property(e => e.PurchaseOrderNo).HasColumnName("PurchaseOrder_No");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.InvPurchaseOrderMaster).WithMany(p => p.InvPurchaseOrderChildren)
                .HasForeignKey(d => new { d.PurchaseOrderNo, d.Site })
                .HasConstraintName("FK_INV_PurchaseOrderChild_INV_PurchaseOrderMaster");
        });

        modelBuilder.Entity<InvPurchaseOrderMaster>(entity =>
        {
            entity.HasKey(e => new { e.PurchaseOrderNo, e.Site });

            entity.ToTable("INV_PurchaseOrderMaster");

            entity.Property(e => e.PurchaseOrderNo).HasColumnName("PurchaseOrder_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.Attention)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryTime)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Delivery_Time");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Amount");
            entity.Property(e => e.DiscountPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Percent");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.IncomeTaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IncomeTax_Amount");
            entity.Property(e => e.IncomeTaxPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IncomeTax_Percent");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.PaymentTerms)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Payment_Terms");
            entity.Property(e => e.PurchaseOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("PurchaseOrder_Date");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvQuotationChild>(entity =>
        {
            entity.HasKey(e => e.SerialNo);

            entity.ToTable("INV_QuotationChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.InvQuotationMaster).WithMany(p => p.InvQuotationChildren)
                .HasForeignKey(d => new { d.TransactionNo, d.Site })
                .HasConstraintName("FK_INV_QuotationChild_INV_QuotationMaster");
        });

        modelBuilder.Entity<InvQuotationMaster>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.Site });

            entity.ToTable("INV_QuotationMaster");

            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.DeliveryDays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Delivery_Days");
            entity.Property(e => e.DeliveryLocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Delivery_Location");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.Taxes)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Terms)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Transaction_Date");
            entity.Property(e => e.ValidityDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Validity_Date");
        });

        modelBuilder.Entity<InvStoreChild>(entity =>
        {
            entity.HasKey(e => e.SerialNo).HasName("PK_INV_Store_Child");

            entity.ToTable("INV_StoreChild");

            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.BalanceQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Qty");
            entity.Property(e => e.BalanceQtyRoll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Qty_Roll");
            entity.Property(e => e.CutLength)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cut_Length");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.IssueQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty");
            entity.Property(e => e.IssueQtyRoll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty_Roll");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.OtherUnit).HasColumnName("Other_Unit");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Received_Qty");
            entity.Property(e => e.ReceivedQtyRolls)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Received_Qty_Rolls");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            entity.Property(e => e.ToStoreId).HasColumnName("To_StoreID");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.InvStoreMaster).WithMany(p => p.InvStoreChildren)
                .HasForeignKey(d => new { d.TransactionNo, d.TransactionType, d.Site })
                .HasConstraintName("FK_INV_StoreChild_INV_StoreMaster");
        });

        modelBuilder.Entity<InvStoreLocation>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.Site });

            entity.ToTable("INV_StoreLocations");

            entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.StoreName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Store_Name");
        });

        modelBuilder.Entity<InvStoreMaster>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.TransactionType, e.Site }).HasName("PK_INV_Store_Master");

            entity.ToTable("INV_StoreMaster");

            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Account_Code");
            entity.Property(e => e.BuiltyNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Builty_No");
            entity.Property(e => e.CottingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cotting_Charges");
            entity.Property(e => e.DcDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DC_No");
            entity.Property(e => e.DemandDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Demand_Date");
            entity.Property(e => e.DemandNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Demand_No");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Department_Code");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Document_No");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.FreightCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Freight_Charges");
            entity.Property(e => e.GrossAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.IgpDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IGP_Date");
            entity.Property(e => e.IgpNo).HasColumnName("IGP_No");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Invoice_No");
            entity.Property(e => e.IssueNo)
                .HasDefaultValue(0)
                .HasColumnName("Issue_No");
            entity.Property(e => e.LoadingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Loading_Charges");
            entity.Property(e => e.ManualIgpDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Manual_IGP_Date");
            entity.Property(e => e.ManualIgpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Manual_IGP_No");
            entity.Property(e => e.NetAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.PoDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PO_Date");
            entity.Property(e => e.PoNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PO_No");
            entity.Property(e => e.PurchaseNo)
                .HasDefaultValue(0)
                .HasColumnName("Purchase_No");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Store_Name");
            entity.Property(e => e.ToStoreId).HasColumnName("To_StoreID");
            entity.Property(e => e.ToStoreName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("To_StoreName");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Transaction_Date");
            entity.Property(e => e.VehicleNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vehicle_No");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WorkOrder_No");
        });

        modelBuilder.Entity<InvViewDemand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_Demand");

            entity.Property(e => e.BalanceQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Qty");
            entity.Property(e => e.DemandDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Demand_Date");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.DemandQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Demand_Qty");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_Code");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequiredQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Required_Qty");
            entity.Property(e => e.RowNo).HasColumnName("Row_No");
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvViewDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_Department");

            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_Code");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.MainCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Main_Code");
            entity.Property(e => e.MainHead)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Head");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainHead)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Head");
        });

        modelBuilder.Entity<InvViewIgp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_IGP");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.DcDate)
                .HasColumnType("datetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DC_No");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.GrnStatus).HasColumnName("GRN_Status");
            entity.Property(e => e.IgpDate)
                .HasColumnType("datetime")
                .HasColumnName("IGP_Date");
            entity.Property(e => e.IgpNo).HasColumnName("IGP_No");
            entity.Property(e => e.IgpQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IGP_Qty");
            entity.Property(e => e.IgpType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IGP_Type");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.ManualIgpDate)
                .HasColumnType("datetime")
                .HasColumnName("Manual_IGP_Date");
            entity.Property(e => e.ManualIgpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Manual_IGP_No");
            entity.Property(e => e.PoDate)
                .HasColumnType("datetime")
                .HasColumnName("PO_Date");
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PO_No");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RemarksChild)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Remarks_Child");
            entity.Property(e => e.SecurityGuard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Security_Guard");
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StoreLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Location");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WorkOrder_No");
        });

        modelBuilder.Entity<InvViewItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_ItemDetail");

            entity.Property(e => e.ControlCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Control_Code");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemMaximumQty).HasColumnName("Item_MaximumQty");
            entity.Property(e => e.ItemMinimumQty).HasColumnName("Item_MinimumQty");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemReOrderLevel).HasColumnName("Item_ReOrderLevel");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Location_Code");
            entity.Property(e => e.LocationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Location_Name");
            entity.Property(e => e.MainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Main_Code");
            entity.Property(e => e.MainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Description");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
        });

        modelBuilder.Entity<InvViewItemOpening>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_ItemOpening");

            entity.Property(e => e.ControlCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Control_Code");
            entity.Property(e => e.ControlDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Control_Description");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemMaximumQty).HasColumnName("Item_MaximumQty");
            entity.Property(e => e.ItemMinimumQty).HasColumnName("Item_MinimumQty");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemOpeningQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Item_OpeningQty");
            entity.Property(e => e.ItemOpeningRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Item_OpeningRate");
            entity.Property(e => e.ItemOpeningValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Item_OpeningValue");
            entity.Property(e => e.ItemReOrderLevel).HasColumnName("Item_ReOrderLevel");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Location_Code");
            entity.Property(e => e.LocationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Location_Name");
            entity.Property(e => e.MainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Main_Code");
            entity.Property(e => e.MainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Description");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
        });

        modelBuilder.Entity<InvViewLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_Locations");

            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Location_Code");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Location_Name");
            entity.Property(e => e.MainCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Main_Code");
            entity.Property(e => e.MainHead)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Main_Head");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainHead)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Head");
        });

        modelBuilder.Entity<InvViewOgp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_OGP");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_ID");
            entity.Property(e => e.Driver)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.OgpDate)
                .HasColumnType("datetime")
                .HasColumnName("OGP_Date");
            entity.Property(e => e.OgpNo).HasColumnName("OGP_No");
            entity.Property(e => e.OgpQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OGP_Qty");
            entity.Property(e => e.OgpType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OGP_Type");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StoreLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Location");
            entity.Property(e => e.Through)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvViewPendingDemand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_PendingDemands");

            entity.Property(e => e.BalanceQuantity)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("Balance_Quantity");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.PoQuantity)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PO_Quantity");
            entity.Property(e => e.RequiredQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Required_Qty");
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvViewPurchaseOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_PurchaseOrder");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Attention)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryTime)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Delivery_Time");
            entity.Property(e => e.DemandNo).HasColumnName("Demand_No");
            entity.Property(e => e.DemandSerialNo).HasColumnName("Demand_SerialNo");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Amount");
            entity.Property(e => e.DiscountPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Percent");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.IgpStatus).HasColumnName("IGP_Status");
            entity.Property(e => e.IncomeTaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IncomeTax_Amount");
            entity.Property(e => e.IncomeTaxPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IncomeTax_Percent");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.PaymentTerms)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Payment_Terms");
            entity.Property(e => e.PoQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PO_Quantity");
            entity.Property(e => e.PurchaseOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("PurchaseOrder_Date");
            entity.Property(e => e.PurchaseOrderNo).HasColumnName("PurchaseOrder_No");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<InvViewQuotation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_Quotation");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.DeliveryDays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Delivery_Days");
            entity.Property(e => e.DeliveryLocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Delivery_Location");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Taxes)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Terms)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Transaction_Date");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.ValidityDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Validity_Date");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<InvViewStoreIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_StoreIssue");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.BalanceQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Qty");
            entity.Property(e => e.BalanceQtyRoll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Qty_Roll");
            entity.Property(e => e.BuiltyNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Builty_No");
            entity.Property(e => e.CottingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cotting_Charges");
            entity.Property(e => e.DcDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DC_No");
            entity.Property(e => e.DemandDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Demand_Date");
            entity.Property(e => e.DemandNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Demand_No");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_Code");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Document_No");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.FreightCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Freight_Charges");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.IgpDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IGP_Date");
            entity.Property(e => e.IgpNo).HasColumnName("IGP_No");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Invoice_No");
            entity.Property(e => e.IssueNo).HasColumnName("Issue_No");
            entity.Property(e => e.IssueQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty");
            entity.Property(e => e.IssueQtyRoll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty_Roll");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.LoadingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Loading_Charges");
            entity.Property(e => e.ManualIgpDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Manual_IGP_Date");
            entity.Property(e => e.ManualIgpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Manual_IGP_No");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.PoDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PO_Date");
            entity.Property(e => e.PoNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PO_No");
            entity.Property(e => e.PurchaseNo).HasColumnName("Purchase_No");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Received_Qty");
            entity.Property(e => e.ReceivedQtyRolls)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Received_Qty_Rolls");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Name");
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
            entity.Property(e => e.ToStoreId).HasColumnName("To_StoreID");
            entity.Property(e => e.ToStoreName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("To_StoreName");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Transaction_Date");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehicleNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vehicle_No");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WorkOrder_No");
        });

        modelBuilder.Entity<InvViewStoreReceive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_View_StoreReceive");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Account_Code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Account_Name");
            entity.Property(e => e.BuiltyNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Builty_No");
            entity.Property(e => e.CottingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cotting_Charges");
            entity.Property(e => e.CutLength)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cut_Length");
            entity.Property(e => e.DcDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_Date");
            entity.Property(e => e.DcNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DC_No");
            entity.Property(e => e.DemandDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Demand_Date");
            entity.Property(e => e.DemandNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Demand_No");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Department_Code");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Document_No");
            entity.Property(e => e.EditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Edit_By");
            entity.Property(e => e.EditTime)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Time");
            entity.Property(e => e.EnterBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Enter_By");
            entity.Property(e => e.EnteryTime)
                .HasColumnType("datetime")
                .HasColumnName("Entery_Time");
            entity.Property(e => e.ExValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ex_Value");
            entity.Property(e => e.FreightCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Freight_Charges");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Amount");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Amount");
            entity.Property(e => e.GstPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST_Percent");
            entity.Property(e => e.IgpDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IGP_Date");
            entity.Property(e => e.IgpNo).HasColumnName("IGP_No");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Invoice_No");
            entity.Property(e => e.IssueNo).HasColumnName("Issue_No");
            entity.Property(e => e.IssueQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty");
            entity.Property(e => e.IssueQtyRoll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Issue_Qty_Roll");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemDescription)
                .IsUnicode(false)
                .HasColumnName("Item_Description");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
            entity.Property(e => e.ItemSpecification)
                .IsUnicode(false)
                .HasColumnName("Item_Specification");
            entity.Property(e => e.ItemUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Item_Unit");
            entity.Property(e => e.LoadingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Loading_Charges");
            entity.Property(e => e.ManualIgpDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Manual_IGP_Date");
            entity.Property(e => e.ManualIgpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Manual_IGP_No");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Amount");
            entity.Property(e => e.OtherUnit).HasColumnName("Other_Unit");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Parent_Code");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Payment_DueDate");
            entity.Property(e => e.PoDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("PO_Date");
            entity.Property(e => e.PoNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PO_No");
            entity.Property(e => e.PurchaseNo).HasColumnName("Purchase_No");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Received_Qty");
            entity.Property(e => e.ReceivedQtyRolls)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Received_Qty_Rolls");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SerialNo).HasColumnName("Serial_No");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Name");
            entity.Property(e => e.SubmainCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Submain_Code");
            entity.Property(e => e.SubmainDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Submain_Description");
            entity.Property(e => e.ToStoreId).HasColumnName("To_StoreID");
            entity.Property(e => e.ToStoreName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("To_StoreName");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Transaction_Date");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction_No");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehicleNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vehicle_No");
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WorkOrder_No");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
