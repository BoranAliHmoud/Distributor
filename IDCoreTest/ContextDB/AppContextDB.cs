using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Transactions;
using IDCoreTest.Helpers;
using IDCoreTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace IDCoreTest.ContextDB;

public partial class AppContextDB : DbContext
{

   
    private readonly ITenantService _tenantService; 
    public AppContextDB(DbContextOptions<AppContextDB> options, ITenantService tenantService)
        : base(options)
    {
        _tenantService = tenantService;
         ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.AutoDetectChangesEnabled = false; // Optional: Disable auto-detect changes
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // Optional: Use NoTracking for better performance
            this.ChangeTracker.LazyLoadingEnabled = false; // Optional: Disable Lazy Loading
            this.ChangeTracker.AutoDetectChangesEnabled = false; // Optional: Disable AutoDetectChanges
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // Optional: Use NoTracking for better performance
            this.Database.AutoTransactionsEnabled = false; // Optional: Disable auto-transactions
        
    }

    public virtual DbSet<HtblCustomer> HtblCustomers { get; set; }

    public virtual DbSet<HtblInvoice> HtblInvoices { get; set; }

    public virtual DbSet<HtblInvoiceLineItem> HtblInvoiceLineItems { get; set; }

    public virtual DbSet<HtblPayment> HtblPayments { get; set; }

    public virtual DbSet<HtblStockDailyBalance> HtblStockDailyBalances { get; set; }

    public virtual DbSet<TblActivity> TblActivities { get; set; }

    public virtual DbSet<TblAdminArea> TblAdminAreas { get; set; }

    public virtual DbSet<TblAppEvent> TblAppEvents { get; set; }

    public virtual DbSet<TblAppPhoto> TblAppPhotos { get; set; }

    public virtual DbSet<TblAsset> TblAssets { get; set; }

    public virtual DbSet<TblBankAccount> TblBankAccounts { get; set; }

    public virtual DbSet<TblBatch> TblBatches { get; set; }

    public virtual DbSet<TblBranch> TblBranches { get; set; }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblCompanyInfo> TblCompanyInfos { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblCurrentLocation> TblCurrentLocations { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblCustomerVisit> TblCustomerVisits { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblExpense> TblExpenses { get; set; }

    public virtual DbSet<TblInvoice> TblInvoices { get; set; }

    public virtual DbSet<TblInvoiceLineItem> TblInvoiceLineItems { get; set; }

    public virtual DbSet<TblJurisdictionPlaceOfSupply> TblJurisdictionPlaceOfSupplies { get; set; }

    public virtual DbSet<TblNoSalesReason> TblNoSalesReasons { get; set; }

    public virtual DbSet<TblOdometerReading> TblOdometerReadings { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblOrderLineItem> TblOrderLineItems { get; set; }

    public virtual DbSet<TblPayment> TblPayments { get; set; }

    public virtual DbSet<TblPlan> TblPlans { get; set; }

    public virtual DbSet<TblPlanItem> TblPlanItems { get; set; }

    public virtual DbSet<TblPriceBook> TblPriceBooks { get; set; }

    public virtual DbSet<TblPriceBookEntry> TblPriceBookEntries { get; set; }

    public virtual DbSet<TblPrivilege> TblPrivileges { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductPackage> TblProductPackages { get; set; }

    public virtual DbSet<TblProductUnit> TblProductUnits { get; set; }

    public virtual DbSet<TblPromotionLineItem> TblPromotionLineItems { get; set; }

    public virtual DbSet<TblPromotionOffer> TblPromotionOffers { get; set; }

    public virtual DbSet<TblPurchaseInvoice> TblPurchaseInvoices { get; set; }

    public virtual DbSet<TblPurchaseInvoiceLineItem> TblPurchaseInvoiceLineItems { get; set; }

    public virtual DbSet<TblRequest> TblRequests { get; set; }

    public virtual DbSet<TblRoute> TblRoutes { get; set; }

    public virtual DbSet<TblRoutePlan> TblRoutePlans { get; set; }

    public virtual DbSet<TblRouteProductCategory> TblRouteProductCategories { get; set; }

    public virtual DbSet<TblSalesTarget> TblSalesTargets { get; set; }

    public virtual DbSet<TblSession> TblSessions  { get; set; }

    public virtual DbSet<TblStock> TblStocks { get; set; }

    public virtual DbSet<TblStockDailyBalance> TblStockDailyBalances { get; set; }

    public virtual DbSet<TblStockDailyLoadBalance> TblStockDailyLoadBalances { get; set; }

    public virtual DbSet<TblStockTransaction> TblStockTransactions { get; set; }

    public virtual DbSet<TblSystemConfig> TblSystemConfigs { get; set; }

    public virtual DbSet<TblTaxMatrix> TblTaxMatrices { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserPrivilege> TblUserPrivileges { get; set; }

    public virtual DbSet<TblVan> TblVans { get; set; }

    public virtual DbSet<TblWorkingArea> TblWorkingAreas { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    SubmitResponseStatusModel result = new SubmitResponseStatusModel();

    //    string accessToken = string.Empty;
    //    if (_httpContext.Items.ContainsKey("accessToken"))
    //    {
    //        accessToken = _httpContext.Items["accessToken"].ToString();

    //    }
    //    if (string.IsNullOrEmpty(accessToken))
    //    {
    //        result.SetResult(false, "Looks up a localized string similar to Invalid Access Token.");
    //        LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken  ");
    //        _httpContext.Response.StatusCode = 200;
    //        return;
    //    }
    //    optionsBuilder.UseSqlServer(accessToken);
    //    optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //}
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //    => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IDDB_TawkeelatJanoub");
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var tenantConnectionString = _tenantService.GetConnectionString();

        if (!string.IsNullOrWhiteSpace(tenantConnectionString))
        {
            var dbProvider = _tenantService.GetDatabaseProvider();

            if (dbProvider?.ToLower() == "mssql")
            {
                optionsBuilder.UseSqlServer(tenantConnectionString);
            }
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_100_CI_AI");

        modelBuilder.Entity<HtblCustomer>(entity =>
        {
            entity.Property(e => e.FldCreditCategory).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldVisitDay).IsFixedLength();
            entity.Property(e => e.FldVisitWeek).IsFixedLength();
        }).UsePropertyAccessMode(PropertyAccessMode.Property);

        modelBuilder.Entity<HtblInvoice>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HtblInvoiceLineItem>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldTaxCategoryCode).HasDefaultValueSql("('SR')");
        });

        modelBuilder.Entity<HtblPayment>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HtblStockDailyBalance>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblActivity>(entity =>
        {
            entity.Property(e => e.FldId).ValueGeneratedNever();
            entity.Property(e => e.FldCode).HasDefaultValueSql("('A-')");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblAdminArea>(entity =>
        {
            entity.HasKey(e => e.FldAreaId).HasName("PK__tblAdminArea");

            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsVisible).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldZoomLevel).HasDefaultValueSql("((8))");
        });

        modelBuilder.Entity<TblAppEvent>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_tblEvent");

            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldEventType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblAppPhoto>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_tblVisitPhoto");

            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldFileType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblAsset>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblBankAccount>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblBatch>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblBranch>(entity =>
        {
            entity.Property(e => e.FldCode).HasDefaultValueSql("('B-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldJurisdiction).HasDefaultValueSql("('NA')");
            entity.Property(e => e.FldType).HasDefaultValueSql("((2))");

            entity.HasOne(d => d.FldParent).WithMany(p => p.InverseFldParent).HasConstraintName("FK_tblBranch_tblBranch");
        });

        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_tblProductCategory");

            entity.Property(e => e.FldCode).HasDefaultValueSql("('C-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDisplayOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblCompanyInfo>(entity =>
        {
            entity.Property(e => e.FldConfigVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldJurisdiction).HasDefaultValueSql("('NA')");
            entity.Property(e => e.FldType).HasDefaultValueSql("((2))");
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldGender).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_tblCurrency_1");

            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPlaces).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblCurrentLocation>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldTime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.Property(e => e.FldAccountStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCreditCategory).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCustomerType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsVisible).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPlaceOfSupply).HasDefaultValueSql("('NA')");
            entity.Property(e => e.FldPriceBookId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldServiceTime).HasDefaultValueSql("((10))");
            entity.Property(e => e.FldVisitDay)
                .HasDefaultValueSql("((1111111))")
                .IsFixedLength();
            entity.Property(e => e.FldVisitWeek)
                .HasDefaultValueSql("((11111))")
                .IsFixedLength();
            entity.Property(e => e.FldZoomLevel).HasDefaultValueSql("((16))");

            entity.HasOne(d => d.FldAdminArea).WithMany(p => p.TblCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomer_tblAdminArea");

            entity.HasOne(d => d.FldCategory).WithMany(p => p.TblCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomer_tblCategory");

            entity.HasOne(d => d.FldCurrency).WithMany(p => p.TblCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomer_tblCurrency");

            entity.HasOne(d => d.FldPriceBook).WithMany(p => p.TblCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomer_tblPriceBook");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblCustomers).HasConstraintName("FK_tblCustomer_tblRoute");

            entity.HasOne(d => d.FldWorkingArea).WithMany(p => p.TblCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomer_tblWorkingArea");
        });

        modelBuilder.Entity<TblCustomerVisit>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDistanceDifference).HasDefaultValueSql("((0))");
            entity.Property(e => e.FldNoSalesReasonId).HasDefaultValueSql("((0))");
            entity.Property(e => e.FldVisitDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldVisitType).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.FldCustomer).WithMany(p => p.TblCustomerVisits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomerVisit_tblCustomer");

            entity.HasOne(d => d.FldNoSalesReason).WithMany(p => p.TblCustomerVisits).HasConstraintName("FK_tblCustomerVisit_tblNoSalesReason");

            entity.HasOne(d => d.FldRoute)
                  .WithMany(p => p.TblCustomerVisits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomerVisit_tblRoute");
        }).UsePropertyAccessMode(PropertyAccessMode.Property);

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.Property(e => e.FldCode).HasDefaultValueSql("('E-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldLastName).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<TblExpense>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCategory).WithMany(p => p.TblExpenses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExpense_tblCategory");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblExpenses).HasConstraintName("FK_tblExpense_tblRoute");
        });

        modelBuilder.Entity<TblInvoice>(entity =>
        {
            entity.ToTable("tblInvoice", tb => tb.HasTrigger("InvoiceSequenceTrigger"));

            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldFlag).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldInvoiceDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldInvoiceType).HasDefaultValueSql("((11))");
            entity.Property(e => e.FldPriceBookId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCustomer).WithMany(p => p.TblInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInvoice_tblCustomer");


            entity.HasOne(d => d.FldCustomerVisit).WithMany(p => p.TblInvoices).HasConstraintName("FK_tblInvoice_tblCustomerVisit");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInvoice_tblRoute");
        });

        modelBuilder.Entity<TblInvoiceLineItem>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldProductUnit).HasDefaultValueSql("('Cur')");
            entity.Property(e => e.FldTaxCategoryCode).HasDefaultValueSql("('SR')");

            entity.HasOne(d => d.FldInvoice).WithMany(p => p.TblInvoiceLineItems).HasConstraintName("FK_tblInvoiceLineItem_tblInvoice");

            entity.HasOne(d => d.FldProduct).WithMany(p => p.TblInvoiceLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInvoiceLineItem_tblProduct");
        });

        modelBuilder.Entity<TblJurisdictionPlaceOfSupply>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblNoSalesReason>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_tblEvaluation");

            entity.Property(e => e.FldId).ValueGeneratedNever();
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDisplayOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblOdometerReading>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldDeliveryType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCustomer).WithMany(p => p.TblOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrder_tblCustomer");

            entity.HasOne(d => d.FldOwnerRoute).WithMany(p => p.TblOrders).HasConstraintName("FK_tblOrder_tblRoute");
        });

        modelBuilder.Entity<TblOrderLineItem>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldProductUnit).HasDefaultValueSql("('')");
            entity.Property(e => e.FldTaxCategoryCode).HasDefaultValueSql("('SR')");

            entity.HasOne(d => d.FldOrder).WithMany(p => p.TblOrderLineItems).HasConstraintName("FK_tblOrderLineItem_tblOrder");

            entity.HasOne(d => d.FldProduct).WithMany(p => p.TblOrderLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineItem_tblProduct");
        });

        modelBuilder.Entity<TblPayment>(entity =>
        {
            entity.Property(e => e.FldCollectionStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldDiscount).HasDefaultValueSql("((0))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCustomer).WithMany(p => p.TblPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPayment_tblCustomer");

            entity.HasOne(d => d.FldCustomerVisit).WithMany(p => p.TblPayments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblPayment_tblCustomerVisit");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblPayments).HasConstraintName("FK_tblPayment_tblRoute");
        });

        modelBuilder.Entity<TblPlan>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblPlanItem>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldSequence).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCustomer).WithMany(p => p.TblPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanItem_tblCustomer");

            entity.HasOne(d => d.FldPlan).WithMany(p => p.TblPlanItems).HasConstraintName("FK_tblPlanItem_tblPlan");
        });

        modelBuilder.Entity<TblPriceBook>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblPriceBookEntry>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldMaxQuantity).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldMinQuantity).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPricingModel).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldTier).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCurrency).WithMany(p => p.TblPriceBookEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPriceBookEntry_tblCurrency");

            entity.HasOne(d => d.FldPriceBook).WithMany(p => p.TblPriceBookEntries).HasConstraintName("FK_tblPriceBookEntry_tblPriceBook");

            entity.HasOne(d => d.FldProduct).WithMany(p => p.TblPriceBookEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPriceBookEntry_tblProduct");
        });

        modelBuilder.Entity<TblPrivilege>(entity =>
        {
            entity.HasKey(e => e.FldPrivilegeId).HasName("PK_tblPrivilages");

            entity.Property(e => e.FldPrivilegeId).ValueGeneratedNever();
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.Property(e => e.FldApplyTax).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldDisplayOrder).HasDefaultValueSql("((100))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsBatchEnabled).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPlaces).HasDefaultValueSql("((2))");
            entity.Property(e => e.FldSalesType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldTaxCategoryCode).HasDefaultValueSql("('SR')");

            entity.HasOne(d => d.FldCategory).WithMany(p => p.TblProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProduct_tblCategory");
        });

        modelBuilder.Entity<TblProductPackage>(entity =>
        {
            entity.Property(e => e.FldConversionQty).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPlaces).HasDefaultValueSql("((2))");

            entity.HasOne(d => d.FldProduct).WithMany(p => p.TblProductPackages).HasConstraintName("FK_tblProductPackage_tblProduct");
        });

        modelBuilder.Entity<TblProductUnit>(entity =>
        {
            entity.HasKey(e => e.FldName).HasName("PK_tblProductUnit_1");

            entity.Property(e => e.FldCode).HasDefaultValueSql("('U-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldId).ValueGeneratedOnAdd();
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblPromotionLineItem>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDiscountType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldMaxQty).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldMinQty).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldProductUnit).HasDefaultValueSql("('')");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldProduct).WithMany(p => p.TblPromotionLineItems).HasConstraintName("FK_tblProduct_tblPromotionLineItem");

            entity.HasOne(d => d.FldPromotion).WithMany(p => p.TblPromotionLineItems).HasConstraintName("FK_tblPromotion_tblPromotionOffer");
        });

        modelBuilder.Entity<TblPromotionOffer>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDiscountType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPriority).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblPurchaseInvoice>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldInvoiceDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldInvoiceStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldPayStatus).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldVendor).WithMany(p => p.TblPurchaseInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPInvoice_tblCompany");
        });

        modelBuilder.Entity<TblPurchaseInvoiceLineItem>(entity =>
        {
            entity.HasKey(e => e.FldInvoiceLineItemId).HasName("PK_tblPInvoiceLineItem");

            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldProductUnit).HasDefaultValueSql("('Cur')");
            entity.Property(e => e.FldTaxCategoryCode).HasDefaultValueSql("('SR')");

            entity.HasOne(d => d.FldInvoice).WithMany(p => p.TblPurchaseInvoiceLineItems).HasConstraintName("FK_tblPInvoiceLineItem_tblPInvoice");

            entity.HasOne(d => d.FldProduct).WithMany(p => p.TblPurchaseInvoiceLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPInvoiceLineItem_tblProduct");
        });

        modelBuilder.Entity<TblRequest>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDeleteDate).IsFixedLength();
            entity.Property(e => e.FldRequestType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldStatus).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldCategory).WithMany(p => p.TblRequests).HasConstraintName("FK_tblRequest_tblCategory");

            entity.HasOne(d => d.FldCustomer).WithMany(p => p.TblRequests)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblRequest_tblCustomer");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblRequests).HasConstraintName("FK_tblRequest_tblRoute");
        });

        modelBuilder.Entity<TblRoute>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldJurisdiction).HasDefaultValueSql("('NA')");
            entity.Property(e => e.FldRouteType).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldWarehouseId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldSalesman).WithMany(p => p.TblRoutes).HasConstraintName("FK_tblRoute_tblEmployee");

            entity.HasOne(d => d.FldStock).WithMany(p => p.TblRoutes).HasConstraintName("FK_tblRoute_tblStock");

            entity.HasOne(d => d.FldVan).WithMany(p => p.TblRoutes).HasConstraintName("FK_tblRoute_tblVan");
        }).UsePropertyAccessMode(PropertyAccessMode.Property);

        modelBuilder.Entity<TblRoutePlan>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldRecurrence).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldVisitDayPattern)
                .HasDefaultValueSql("((1111111))")
                .IsFixedLength();
            entity.Property(e => e.FldVisitMonthDaysPattern)
                .HasDefaultValueSql("((11111))")
                .IsFixedLength();
            entity.Property(e => e.FldVisitMonthPattern)
                .HasDefaultValueSql("((11111))")
                .IsFixedLength();
            entity.Property(e => e.FldVisitWeekPattern)
                .HasDefaultValueSql("((11111))")
                .IsFixedLength();

            entity.HasOne(d => d.FldPlan).WithMany(p => p.TblRoutePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoutePlan_tblPlan");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblRoutePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoutePlan_tblRoute");
        });

        modelBuilder.Entity<TblRouteProductCategory>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldDisplayOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblSalesTarget>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCurrencyId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldExchangeRate).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblSession>(entity =>
        {
            entity.Property(e => e.FldSessionDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldStartTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldStatus).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<TblStock>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldType)
                .HasDefaultValueSql("((1))")
                .HasComment("1 warehouse - 2 route stock");
        });

        modelBuilder.Entity<TblStockDailyBalance>(entity =>
        {
            entity.Property(e => e.CloseBalance).HasComputedColumnSql("((((((((((([InitialBalance]+[LoadBalance])-[DamageBalance])+[adjust])+[ResellBalance])+[LoadUnPack])+[TransferInBalance])-[TransferOutBalance])-[SalesBalance])-[OfferBalance])-[UnPack])-[UnLoad])", false);
            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ProductUnit).HasDefaultValueSql("((0))");
            entity.Property(e => e.StartBalance).HasComputedColumnSql("([InitialBalance]+[LoadBalance])", false);

            entity.HasOne(d => d.Prod).WithMany(p => p.TblStockDailyBalances).HasConstraintName("FK_tblStockDailyBalance_tblProduct");

            entity.HasOne(d => d.Stock).WithMany(p => p.TblStockDailyBalances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStockDailyBalance_tblStock");
        });

        modelBuilder.Entity<TblStockDailyLoadBalance>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_StockDailyLoadBalance");

            entity.Property(e => e.FldDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldProductUnit).HasDefaultValueSql("((0))");
            entity.Property(e => e.FldType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblStockTransaction>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldTransactionDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.FldProd).WithMany(p => p.TblStockTransactions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblStockTransactions_tblProduct");
        });

        modelBuilder.Entity<TblSystemConfig>(entity =>
        {
            entity.Property(e => e.FldValueType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblTaxMatrix>(entity =>
        {
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.FldUserId).HasName("PK_tblUsers");

            entity.Property(e => e.FldAllowedDistance).HasDefaultValueSql("((-1))");
            entity.Property(e => e.FldCode).HasDefaultValueSql("('U-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldSessionLifeTime).HasDefaultValueSql("((24))");
            entity.Property(e => e.FldUserType).HasDefaultValueSql("('IDV')");
        });

        modelBuilder.Entity<TblUserPrivilege>(entity =>
        {
            entity.HasKey(e => new { e.FldUserId, e.FldPrivilegeId }).HasName("PK_tblUserPrivilage");

            entity.Property(e => e.FldCreationDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.FldPrivilege).WithMany(p => p.TblUserPrivileges).HasConstraintName("FK_tblUserPrivilege_tblPrivilege");

            entity.HasOne(d => d.FldUser).WithMany(p => p.TblUserPrivileges).HasConstraintName("FK_tblUserPrivilege_tblUser");
        });

        modelBuilder.Entity<TblVan>(entity =>
        {
            entity.HasKey(e => e.FldVanId).HasName("PK_tblVehicle");

            entity.Property(e => e.FldCode).HasDefaultValueSql("('V-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FldDriver).WithMany(p => p.TblVans).HasConstraintName("FK_tblVehicle_tblEmployee");
        });

        modelBuilder.Entity<TblWorkingArea>(entity =>
        {
            entity.HasKey(e => e.FldWorkingAreaId).HasName("PK__TBLWORKI__D27FF6E4BD5AFE7C");

            entity.Property(e => e.FldCode).HasDefaultValueSql("('W-')");
            entity.Property(e => e.FldCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FldIsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.FldZoomLevel).HasDefaultValueSql("((10))");

            entity.HasOne(d => d.FldAdminArea).WithMany(p => p.TblWorkingAreas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblWorkingArea_tblAdminArea");

            entity.HasOne(d => d.FldRoute).WithMany(p => p.TblWorkingAreas).HasConstraintName("FK_tblWorkingArea_tblRoute");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
