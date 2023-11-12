using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IDCoreTest.Migrations
{
    /// <inheritdoc />
    public partial class addDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HtblCustomer",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldWorkingAreaID = table.Column<long>(type: "bigint", nullable: false),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldAltRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldActivityID = table.Column<long>(type: "bigint", nullable: false),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldContactPerson = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldNationalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldMobilePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldTelephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldOtherTelephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    fldPriceBookId = table.Column<long>(type: "bigint", nullable: false),
                    fldLongitude = table.Column<double>(type: "float", nullable: true),
                    fldLatitude = table.Column<double>(type: "float", nullable: true),
                    fldLicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldWorkingHours = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldServiceTime = table.Column<double>(type: "float", nullable: false),
                    fldEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldTRN = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldVisitWeek = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: true),
                    fldVisitDay = table.Column<string>(type: "nchar(7)", fixedLength: true, maxLength: 7, nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldAccessChannel = table.Column<long>(type: "bigint", nullable: true),
                    fldPOBox = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    fldDefaultDiscount = table.Column<double>(type: "float", nullable: false),
                    fldCreditDays = table.Column<int>(type: "int", nullable: false),
                    fldCreditCategory = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldLicenseExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldPlaceOfSupply = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldWebsite = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtblCustomer", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "HtblInvoice",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: true),
                    fldInvoiceType = table.Column<int>(type: "int", nullable: true),
                    fldInvoiceCollectionStatus = table.Column<int>(type: "int", nullable: true),
                    fldInvoiceDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldInvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldSalesInvoiceNumber = table.Column<long>(type: "bigint", nullable: true),
                    fldRefOrderID = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerVisitID = table.Column<long>(type: "bigint", nullable: false),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: false),
                    fldTotalSales = table.Column<double>(type: "float", nullable: true),
                    fldDiscount = table.Column<double>(type: "float", nullable: true),
                    fldNetTotal = table.Column<double>(type: "float", nullable: true),
                    fldVATValue = table.Column<double>(type: "float", nullable: true),
                    fldGrandTotal = table.Column<double>(type: "float", nullable: true),
                    fldTotalCollection = table.Column<double>(type: "float", nullable: true),
                    fldInvoiceCreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldComments = table.Column<string>(type: "text", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldPriceBookId = table.Column<long>(type: "bigint", nullable: true),
                    fldDeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    fldLPONumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldPlaceOfSupply = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldPayTerms = table.Column<int>(type: "int", nullable: false),
                    fldDeliveryTerms = table.Column<int>(type: "int", nullable: false),
                    fldDriverId = table.Column<long>(type: "bigint", nullable: true),
                    fldHelperId = table.Column<long>(type: "bigint", nullable: true),
                    fldStockId = table.Column<long>(type: "bigint", nullable: true),
                    fldReceiverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldReceiverMobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCustomerBalance = table.Column<double>(type: "float", nullable: false),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldSequence = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtblInvoice", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "HtblInvoiceLineItem",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldlnvoiceLineItemID = table.Column<long>(type: "bigint", nullable: true),
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldQty = table.Column<double>(type: "float", nullable: true),
                    fldOfferQty = table.Column<double>(type: "float", nullable: true),
                    fldPrice = table.Column<double>(type: "float", nullable: false),
                    fldDiscount = table.Column<double>(type: "float", nullable: true),
                    fldValue = table.Column<double>(type: "float", nullable: true),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldReturnQty = table.Column<double>(type: "float", nullable: true),
                    fldItemCreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldTaxCategoryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('SR')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtblInvoiceLineItem", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "HtblPayment",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldPaymentID = table.Column<long>(type: "bigint", nullable: true),
                    fldPaymentCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldInvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldRefInvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    fldAmount = table.Column<double>(type: "float", nullable: true),
                    fldPaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldPaymentType = table.Column<int>(type: "int", nullable: false),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerVisitID = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: true),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldNotes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    fldChequeNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    fldChequeDate = table.Column<DateTime>(type: "date", nullable: true),
                    fldChequePhotoUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fldPaymentCreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    fldComments = table.Column<string>(type: "text", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldCollectionStatus = table.Column<int>(type: "int", nullable: true),
                    fldCollectionDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtblPayment", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "HtblStockDailyBalance",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldOrginialId = table.Column<long>(type: "bigint", nullable: false),
                    fldStockID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldInitialBalance = table.Column<double>(type: "float", nullable: false),
                    fldLoadBalance = table.Column<double>(type: "float", nullable: false),
                    fldStartBalance = table.Column<double>(type: "float", nullable: false),
                    fldDamageBalance = table.Column<double>(type: "float", nullable: false),
                    fldResellBalance = table.Column<double>(type: "float", nullable: false),
                    fldTransferInBalance = table.Column<double>(type: "float", nullable: false),
                    fldTransferOutBalance = table.Column<double>(type: "float", nullable: false),
                    fldSalesBalance = table.Column<double>(type: "float", nullable: false),
                    fldAdjust = table.Column<double>(type: "float", nullable: false),
                    fldDate = table.Column<DateTime>(type: "date", nullable: false),
                    fldOfferBalance = table.Column<double>(type: "float", nullable: false),
                    fldCloseBalance = table.Column<double>(type: "float", nullable: false),
                    fldUnPack = table.Column<double>(type: "float", nullable: false),
                    fldLoadUnPack = table.Column<double>(type: "float", nullable: false),
                    fldUnLoad = table.Column<double>(type: "float", nullable: false),
                    fldOriginalCreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtblStockDailyBalance", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblActivity",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false),
                    fldName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fldGooglePlaceType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fldDisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fldIcon = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('A-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblActivity", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblAdminArea",
                columns: table => new
                {
                    fldAreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldType = table.Column<int>(type: "int", nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldParentArea_ID = table.Column<long>(type: "bigint", nullable: true),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldCenter_x = table.Column<double>(type: "float", nullable: true),
                    fldCenter_y = table.Column<double>(type: "float", nullable: true),
                    fldZoomLevel = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((8))"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIsVisible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldDisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblAdminArea", x => x.fldAreaID);
                });

            migrationBuilder.CreateTable(
                name: "tblAppEvent",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldUserId = table.Column<long>(type: "bigint", nullable: false),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: false),
                    fldSalesmanId = table.Column<long>(type: "bigint", nullable: false),
                    fldInvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    fldPaymentId = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    fldEventTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldEventType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldLatitude = table.Column<double>(type: "float", nullable: true),
                    fldLongitude = table.Column<double>(type: "float", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldEventEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEvent", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblAppPhoto",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldProductId = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldPhotoUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    fldLatitude = table.Column<double>(type: "float", nullable: true),
                    fldLongitude = table.Column<double>(type: "float", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldInvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    fldPaymentId = table.Column<long>(type: "bigint", nullable: true),
                    fldVisitId = table.Column<long>(type: "bigint", nullable: true),
                    fldExpenseId = table.Column<long>(type: "bigint", nullable: true),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    fldPromotionOfferId = table.Column<long>(type: "bigint", nullable: true),
                    fldVanId = table.Column<long>(type: "bigint", nullable: true),
                    fldEmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldOrderId = table.Column<long>(type: "bigint", nullable: true),
                    fldAssetId = table.Column<long>(type: "bigint", nullable: true),
                    fldFileType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVisitPhoto", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblAsset",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: true),
                    fldInstallationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldStatus = table.Column<int>(type: "int", nullable: false),
                    fldCost = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldLatitude = table.Column<double>(type: "float", nullable: true),
                    fldLongitude = table.Column<double>(type: "float", nullable: true),
                    fldDescription = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastInspectionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAsset", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblBankAccount",
                columns: table => new
                {
                    fldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldAccountName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldAccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldReceiptMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldBankName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldBankAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldIBAN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBankAccount", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblBatch",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldProductId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBatch", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblBranch",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))"),
                    fldManager = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldTelephone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldParentId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('B-')"),
                    fldEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('NA')"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldTaxRegisterationNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fldLicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIDMLicenses = table.Column<int>(type: "int", nullable: false),
                    fldIDVLicenses = table.Column<int>(type: "int", nullable: false),
                    fldIntegrationTransactionTypeReturnCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationTransactionTypeSalesCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldBankAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldInvoiceReportTemplate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldOrderReportTemplate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranch", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblBranch_tblBranch",
                        column: x => x.fldParentId,
                        principalTable: "tblBranch",
                        principalColumn: "fldId");
                });

            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    fldParentId = table.Column<long>(type: "bigint", nullable: true),
                    fldLevel = table.Column<int>(type: "int", nullable: false),
                    fldDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldCoverPhoto = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldDisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('C-')"),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductCategory", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanyInfo",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))"),
                    fldName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    fldTelephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldWebsite = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldLogoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    fldContactName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldTaxRegisterationNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fldTaxPercentage = table.Column<double>(type: "float", nullable: false),
                    fldLicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldLicenseExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldConfigVersion = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldRegistrationCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldIDMLicenses = table.Column<int>(type: "int", nullable: false),
                    fldIDVLicenses = table.Column<int>(type: "int", nullable: false),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCountryId = table.Column<long>(type: "bigint", nullable: true),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('NA')"),
                    fldBaseUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    fldInvoiceReportTemplate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationkey = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldIntegrationUsername = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldIntegrationPassword = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldRegistrationStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldRegistrationEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldOrderReportTemplate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanyInfo", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblContact",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    fldPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldContactEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldTelephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldGender = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldBirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldHasAccessPortal = table.Column<bool>(type: "bit", nullable: false),
                    fldPortalPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContact", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblCurrency",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldSymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    fldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldIsMainCurrency = table.Column<bool>(type: "bit", nullable: false),
                    fldPlaces = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCurrency_1", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblCurrentLocation",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldLat = table.Column<double>(type: "float", nullable: false),
                    fldLon = table.Column<double>(type: "float", nullable: false),
                    fldTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCurrentLocation", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployee",
                columns: table => new
                {
                    fldEmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    fldLastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "('')"),
                    fldPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldManagerID = table.Column<long>(type: "bigint", nullable: true),
                    fldBirthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldMobilePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldLandLine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldAddress = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldNationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldNationalNumber = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldLicenseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldLicenseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldEmploymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldNote = table.Column<string>(type: "text", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldRole = table.Column<int>(type: "int", nullable: true),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('E-')"),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployee", x => x.fldEmpID);
                });

            migrationBuilder.CreateTable(
                name: "tblJurisdictionPlaceOfSupply",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblJurisdictionPlaceOfSupply", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblNoSalesReason",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false),
                    fldName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldDisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEvaluation", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblOdometerReading",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldOdometer = table.Column<double>(type: "float", nullable: false),
                    fldType = table.Column<int>(type: "int", nullable: false),
                    fldLatitude = table.Column<double>(type: "float", nullable: false),
                    fldLongitude = table.Column<double>(type: "float", nullable: false),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOdometerReading", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblPlan",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlan", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblPriceBook",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldIsDefault = table.Column<bool>(type: "bit", nullable: false),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPriceBook", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblPrivilege",
                columns: table => new
                {
                    fldPrivilegeID = table.Column<long>(type: "bigint", nullable: false),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fldTName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    fldTDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    fldGroupId = table.Column<int>(type: "int", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPrivilages", x => x.fldPrivilegeID);
                });

            migrationBuilder.CreateTable(
                name: "tblProductUnit",
                columns: table => new
                {
                    fldName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('U-')"),
                    fldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductUnit_1", x => x.fldName);
                });

            migrationBuilder.CreateTable(
                name: "tblPromotionOffer",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldStatus = table.Column<int>(type: "int", nullable: false),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldMaxQuantity = table.Column<double>(type: "float", nullable: true),
                    fldMaxValue = table.Column<double>(type: "float", nullable: false),
                    fldMinValue = table.Column<double>(type: "float", nullable: false),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldPriceBookId = table.Column<long>(type: "bigint", nullable: true),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldDiscountType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCustomerId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldProductId = table.Column<long>(type: "bigint", nullable: true),
                    fldWorkingAreaId = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    fldAvailableQuantity = table.Column<double>(type: "float", nullable: false),
                    fldMaxSalesQty = table.Column<double>(type: "float", nullable: true),
                    fldMinSalesQty = table.Column<double>(type: "float", nullable: true),
                    fldPriority = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPromotionOffer", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblRouteProductCategory",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: false),
                    fldProductId = table.Column<long>(type: "bigint", nullable: true),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldCreateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldDisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRouteProductCategory", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblSalesTarget",
                columns: table => new
                {
                    fldSalesTargetID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldProductID = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: true),
                    fldAmount = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldType = table.Column<int>(type: "int", nullable: false),
                    fldDescription = table.Column<string>(type: "text", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    fldEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalesTarget", x => x.fldSalesTargetID);
                });

            migrationBuilder.CreateTable(
                name: "tblSession",
                columns: table => new
                {
                    fldSessionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldSessionDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    fldUserID = table.Column<long>(type: "bigint", nullable: true),
                    fldUserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fldStartTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldStatus = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    fldClientIP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fldClientBrowser = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldTrrUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSession", x => x.fldSessionID);
                });

            migrationBuilder.CreateTable(
                name: "tblStock",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "1 warehouse - 2 route stock"),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStock", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblStockDailyLoadBalance",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldStockID = table.Column<long>(type: "bigint", nullable: false),
                    fldProdID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "((0))"),
                    fldLoadQty = table.Column<double>(type: "float", nullable: false),
                    fldActualLoadQty = table.Column<double>(type: "float", nullable: false),
                    fldIsApplied = table.Column<bool>(type: "bit", nullable: false),
                    fldDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldAppliedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldWarehouseId = table.Column<long>(type: "bigint", nullable: true),
                    fldOrderId = table.Column<long>(type: "bigint", nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldRequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationStatusMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockDailyLoadBalance", x => x.fldID);
                });

            migrationBuilder.CreateTable(
                name: "tblSystemConfig",
                columns: table => new
                {
                    fldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldConfigKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldConfigValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldValueType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    fldMinValue = table.Column<double>(type: "float", nullable: true),
                    fldMaxValue = table.Column<double>(type: "float", nullable: true),
                    fldStepValue = table.Column<double>(type: "float", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldTranslatedDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSystemConfig", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblTaxMatrix",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCategory = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    fldTaxCode = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    fldPlaceOfSupply = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldValue = table.Column<double>(type: "float", nullable: false),
                    fldVoucherType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTaxMatrix", x => x.fldId);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    fldUserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false),
                    fldActivationKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldUserType = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('IDV')"),
                    fldDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('U-')"),
                    fldSessionLifeTime = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((24))"),
                    fldAllowedDistance = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((-1))"),
                    fldRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.fldUserID);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    fldProdID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fldBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    fldBaseUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fldCostPrice = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldCompany = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldTax = table.Column<double>(type: "float", nullable: false),
                    fldShelfLifeDays = table.Column<int>(type: "int", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldMinStockAlert = table.Column<double>(type: "float", nullable: true),
                    fldIsBatchEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldTaxCategoryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('SR')"),
                    fldTaxCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldApplyTax = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldApplyFurtherTax = table.Column<bool>(type: "bit", nullable: false),
                    fldSubCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    fldTag = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldDisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((100))"),
                    fldPlaces = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))"),
                    fldDisplayUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldSalesType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.fldProdID);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblCategory",
                        column: x => x.fldCategoryID,
                        principalTable: "tblCategory",
                        principalColumn: "fldId");
                });

            migrationBuilder.CreateTable(
                name: "tblPurchaseInvoice",
                columns: table => new
                {
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldInvoiceStatus = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldInvoiceDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldInvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldVendorID = table.Column<long>(type: "bigint", nullable: false),
                    fldTotalSales = table.Column<double>(type: "float", nullable: false),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldNetTotal = table.Column<double>(type: "float", nullable: false),
                    fldVATValue = table.Column<double>(type: "float", nullable: false),
                    fldGrandTotal = table.Column<double>(type: "float", nullable: false),
                    fldTotalCollection = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldWarehouseId = table.Column<long>(type: "bigint", nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldPaidAmount = table.Column<double>(type: "float", nullable: false),
                    fldPayStatus = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPurchaseInvoice", x => x.fldInvoiceID);
                    table.ForeignKey(
                        name: "FK_tblPInvoice_tblCompany",
                        column: x => x.fldVendorID,
                        principalTable: "tblCompanyInfo",
                        principalColumn: "fldID");
                });

            migrationBuilder.CreateTable(
                name: "tblVan",
                columns: table => new
                {
                    fldVanID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    fldDriverID = table.Column<long>(type: "bigint", nullable: true),
                    fldPlateNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fldPurchaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldModelYear = table.Column<int>(type: "int", nullable: true),
                    fldChassisNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldRegisterationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldInsuranceExpriyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldInsuranceCompany = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldTrafficCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldVolume = table.Column<double>(type: "float", nullable: true),
                    fldWeight = table.Column<double>(type: "float", nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('V-')"),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVehicle", x => x.fldVanID);
                    table.ForeignKey(
                        name: "FK_tblVehicle_tblEmployee",
                        column: x => x.fldDriverID,
                        principalTable: "tblEmployee",
                        principalColumn: "fldEmpID");
                });

            migrationBuilder.CreateTable(
                name: "tblUserPrivilege",
                columns: table => new
                {
                    fldUserId = table.Column<long>(type: "bigint", nullable: false),
                    fldPrivilegeId = table.Column<long>(type: "bigint", nullable: false),
                    fldCreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserPrivilage", x => new { x.fldUserId, x.fldPrivilegeId });
                    table.ForeignKey(
                        name: "FK_tblUserPrivilege_tblPrivilege",
                        column: x => x.fldPrivilegeId,
                        principalTable: "tblPrivilege",
                        principalColumn: "fldPrivilegeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblUserPrivilege_tblUser",
                        column: x => x.fldUserId,
                        principalTable: "tblUser",
                        principalColumn: "fldUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPriceBookEntry",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldPriceBookId = table.Column<long>(type: "bigint", nullable: false),
                    fldProductId = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldPrice = table.Column<double>(type: "float", nullable: false),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldMinQuantity = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldMaxQuantity = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldPricingModel = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldFlatFee = table.Column<double>(type: "float", nullable: false),
                    fldTier = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldDiscount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPriceBookEntry", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblPriceBookEntry_tblCurrency",
                        column: x => x.fldCurrencyId,
                        principalTable: "tblCurrency",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblPriceBookEntry_tblPriceBook",
                        column: x => x.fldPriceBookId,
                        principalTable: "tblPriceBook",
                        principalColumn: "fldId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPriceBookEntry_tblProduct",
                        column: x => x.fldProductId,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID");
                });

            migrationBuilder.CreateTable(
                name: "tblProductPackage",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldProductId = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fldBarcode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldCostPrice = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldConversionQty = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldUnitVolume = table.Column<double>(type: "float", nullable: true),
                    fldUnitWeight = table.Column<double>(type: "float", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldMinStockAlert = table.Column<double>(type: "float", nullable: true),
                    fldProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldProductUnitCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldPlaces = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductPackage", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblProductPackage_tblProduct",
                        column: x => x.fldProductId,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPromotionLineItem",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldPromotionID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductID = table.Column<long>(type: "bigint", nullable: true),
                    fldQty = table.Column<double>(type: "float", nullable: false),
                    fldType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldProductUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    fldMaxQty = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldMinQty = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldDiscountType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldMaxSalesValue = table.Column<double>(type: "float", nullable: true),
                    fldMinSalesValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPromotionLineItem", x => x.fldID);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblPromotionLineItem",
                        column: x => x.fldProductID,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID");
                    table.ForeignKey(
                        name: "FK_tblPromotion_tblPromotionOffer",
                        column: x => x.fldPromotionID,
                        principalTable: "tblPromotionOffer",
                        principalColumn: "fldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStockDailyBalance",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockID = table.Column<long>(type: "bigint", nullable: false),
                    ProdID = table.Column<long>(type: "bigint", nullable: false),
                    ProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "((0))"),
                    InitialBalance = table.Column<double>(type: "float", nullable: false),
                    LoadBalance = table.Column<double>(type: "float", nullable: false),
                    StartBalance = table.Column<double>(type: "float", nullable: false, computedColumnSql: "([InitialBalance]+[LoadBalance])", stored: false),
                    DamageBalance = table.Column<double>(type: "float", nullable: false),
                    ResellBalance = table.Column<double>(type: "float", nullable: false),
                    TransferInBalance = table.Column<double>(type: "float", nullable: false),
                    TransferOutBalance = table.Column<double>(type: "float", nullable: false),
                    SalesBalance = table.Column<double>(type: "float", nullable: false),
                    adjust = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    OfferBalance = table.Column<double>(type: "float", nullable: false),
                    CloseBalance = table.Column<double>(type: "float", nullable: false, computedColumnSql: "((((((((((([InitialBalance]+[LoadBalance])-[DamageBalance])+[adjust])+[ResellBalance])+[LoadUnPack])+[TransferInBalance])-[TransferOutBalance])-[SalesBalance])-[OfferBalance])-[UnPack])-[UnLoad])", stored: false),
                    UnPack = table.Column<double>(type: "float", nullable: false),
                    LoadUnPack = table.Column<double>(type: "float", nullable: false),
                    UnLoad = table.Column<double>(type: "float", nullable: false),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStockDailyBalance", x => x.fldID);
                    table.ForeignKey(
                        name: "FK_tblStockDailyBalance_tblProduct",
                        column: x => x.ProdID,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblStockDailyBalance_tblStock",
                        column: x => x.StockID,
                        principalTable: "tblStock",
                        principalColumn: "fldID");
                });

            migrationBuilder.CreateTable(
                name: "tblStockTransactions",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldSourceID = table.Column<long>(type: "bigint", nullable: true),
                    fldDestinationID = table.Column<long>(type: "bigint", nullable: true),
                    fldTransactionDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: true),
                    fldProdID = table.Column<long>(type: "bigint", nullable: true),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    fldQty = table.Column<double>(type: "float", nullable: false),
                    fldlnvoiceLineItemID = table.Column<long>(type: "bigint", nullable: true),
                    fldBeforeQty = table.Column<double>(type: "float", nullable: true),
                    fldType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsSourceCustomer = table.Column<bool>(type: "bit", nullable: true),
                    IsDestinationCustomer = table.Column<bool>(type: "bit", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    fldTransactionType = table.Column<int>(type: "int", nullable: false),
                    fldComments = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStockTransactions", x => x.fldID);
                    table.ForeignKey(
                        name: "FK_tblStockTransactions_tblProduct",
                        column: x => x.fldProdID,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPurchaseInvoiceLineItem",
                columns: table => new
                {
                    fldInvoiceLineItemID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "('Cur')"),
                    fldQty = table.Column<double>(type: "float", nullable: false),
                    fldOfferQty = table.Column<double>(type: "float", nullable: false),
                    fldReturnQty = table.Column<double>(type: "float", nullable: false),
                    fldPrice = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldTaxValue = table.Column<double>(type: "float", nullable: false),
                    fldValue = table.Column<double>(type: "float", nullable: false),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldTaxCategoryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('SR')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPInvoiceLineItem", x => x.fldInvoiceLineItemID);
                    table.ForeignKey(
                        name: "FK_tblPInvoiceLineItem_tblPInvoice",
                        column: x => x.fldInvoiceID,
                        principalTable: "tblPurchaseInvoice",
                        principalColumn: "fldInvoiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPInvoiceLineItem_tblProduct",
                        column: x => x.fldProductID,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID");
                });

            migrationBuilder.CreateTable(
                name: "tblRoute",
                columns: table => new
                {
                    fldRouteID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldRouteName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldVanID = table.Column<long>(type: "bigint", nullable: true),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: true),
                    fldStockID = table.Column<long>(type: "bigint", nullable: true),
                    fldPlanId = table.Column<long>(type: "bigint", nullable: true),
                    fldMaxDiscount = table.Column<double>(type: "float", nullable: false),
                    fldRouteType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCreditLimit = table.Column<double>(type: "float", nullable: false),
                    fldCurrentBalance = table.Column<double>(type: "float", nullable: false),
                    fldRouteColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldSalesTarget = table.Column<double>(type: "float", nullable: false),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldWarehouseId = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('NA')"),
                    fldDriverId = table.Column<long>(type: "bigint", nullable: true),
                    fldHelperId = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCashBalance = table.Column<double>(type: "float", nullable: false),
                    fldReturnBalance = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    fldInitialBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoute", x => x.fldRouteID);
                    table.ForeignKey(
                        name: "FK_tblRoute_tblEmployee",
                        column: x => x.fldSalesmanID,
                        principalTable: "tblEmployee",
                        principalColumn: "fldEmpID");
                    table.ForeignKey(
                        name: "FK_tblRoute_tblStock",
                        column: x => x.fldStockID,
                        principalTable: "tblStock",
                        principalColumn: "fldID");
                    table.ForeignKey(
                        name: "FK_tblRoute_tblVan",
                        column: x => x.fldVanID,
                        principalTable: "tblVan",
                        principalColumn: "fldVanID");
                });

            migrationBuilder.CreateTable(
                name: "tblExpense",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    fldAmount = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    fldExpenseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldReceiptPhoto = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    fldPurchaseInvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblExpense", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblExpense_tblCategory",
                        column: x => x.fldCategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblExpense_tblRoute",
                        column: x => x.fldRouteId,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblRoutePlan",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: false),
                    fldPlanId = table.Column<long>(type: "bigint", nullable: false),
                    fldType = table.Column<int>(type: "int", nullable: false),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldComments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    fldStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldRecurrence = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldVisitWeekPattern = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: true, defaultValueSql: "((11111))"),
                    fldVisitDayPattern = table.Column<string>(type: "nchar(7)", fixedLength: true, maxLength: 7, nullable: true, defaultValueSql: "((1111111))"),
                    fldVisitMonthPattern = table.Column<string>(type: "nchar(12)", fixedLength: true, maxLength: 12, nullable: true, defaultValueSql: "((11111))"),
                    fldVisitMonthDaysPattern = table.Column<string>(type: "nchar(31)", fixedLength: true, maxLength: 31, nullable: true, defaultValueSql: "((11111))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoutePlan", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblRoutePlan_tblPlan",
                        column: x => x.fldPlanId,
                        principalTable: "tblPlan",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblRoutePlan_tblRoute",
                        column: x => x.fldRouteId,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblWorkingArea",
                columns: table => new
                {
                    fldWorkingAreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fldName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    fldAdminAreaID = table.Column<long>(type: "bigint", nullable: false),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldCenter_x = table.Column<double>(type: "float", nullable: true),
                    fldCenter_y = table.Column<double>(type: "float", nullable: true),
                    fldZoomLevel = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((10))"),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('W-')"),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TBLWORKI__D27FF6E4BD5AFE7C", x => x.fldWorkingAreaID);
                    table.ForeignKey(
                        name: "FK_tblWorkingArea_tblAdminArea",
                        column: x => x.fldAdminAreaID,
                        principalTable: "tblAdminArea",
                        principalColumn: "fldAreaID");
                    table.ForeignKey(
                        name: "FK_tblWorkingArea_tblRoute",
                        column: x => x.fldRouteID,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblCustomer",
                columns: table => new
                {
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCustomerCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldAdminAreaID = table.Column<long>(type: "bigint", nullable: false),
                    fldWorkingAreaID = table.Column<long>(type: "bigint", nullable: false),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldActivityID = table.Column<long>(type: "bigint", nullable: false),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    fldTranslatedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fldContactPerson = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldNationalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldMobilePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldTelephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldOtherTelephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCurrentBalance = table.Column<double>(type: "float", nullable: false),
                    fldCreditLimit = table.Column<int>(type: "int", nullable: false),
                    fldMaxDiscount = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldPriceBookId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldLongitude = table.Column<double>(type: "float", nullable: true),
                    fldLatitude = table.Column<double>(type: "float", nullable: true),
                    fldZoomLevel = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((16))"),
                    fldIsVisible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldWorkingHours = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldServiceTime = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((10))"),
                    fldEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldTRN = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldVisitWeek = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: true, defaultValueSql: "((11111))"),
                    fldVisitDay = table.Column<string>(type: "nchar(7)", fixedLength: true, maxLength: 7, nullable: true, defaultValueSql: "((1111111))"),
                    fldLicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldAccessChannel = table.Column<long>(type: "bigint", nullable: true),
                    fldIsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fldCreateEmployeeID = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldPOBox = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    fldDefaultDiscount = table.Column<double>(type: "float", nullable: false),
                    fldCreditDays = table.Column<int>(type: "int", nullable: false),
                    fldCreditCategory = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldLicenseExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldPlaceOfSupply = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('NA')"),
                    fldFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldWebsite = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldCustomerType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldIntegrationPartyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationBillSiteId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationAccountId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationShipSiteId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationSiteAddressNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationAddressId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastVisitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastVisitResult = table.Column<int>(type: "int", nullable: true),
                    fldLastCreditInvoiceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldShipToAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldShipToName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldShipToTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldShipToEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldInitialBalance = table.Column<double>(type: "float", nullable: false),
                    fldCnic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldNtn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIsConsignment = table.Column<bool>(type: "bit", nullable: false),
                    fldPayTerms = table.Column<int>(type: "int", nullable: false),
                    fldGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldAccountStatus = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldIsGroup = table.Column<bool>(type: "bit", nullable: false),
                    fldIntegrationStatusMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomer", x => x.fldCustomerID);
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblAdminArea",
                        column: x => x.fldAdminAreaID,
                        principalTable: "tblAdminArea",
                        principalColumn: "fldAreaID");
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblCategory",
                        column: x => x.fldCategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblCurrency",
                        column: x => x.fldCurrencyId,
                        principalTable: "tblCurrency",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblPriceBook",
                        column: x => x.fldPriceBookId,
                        principalTable: "tblPriceBook",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblRoute",
                        column: x => x.fldRouteID,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblWorkingArea",
                        column: x => x.fldWorkingAreaID,
                        principalTable: "tblWorkingArea",
                        principalColumn: "fldWorkingAreaID");
                });

            migrationBuilder.CreateTable(
                name: "tblCustomerVisit",
                columns: table => new
                {
                    fldCustomerVisitID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldVisitDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldArriveTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldArrivalLatitude = table.Column<double>(type: "float", nullable: true),
                    fldArrivalLongitude = table.Column<double>(type: "float", nullable: true),
                    fldDepartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldDepartLatitude = table.Column<double>(type: "float", nullable: true),
                    fldDepartLongitude = table.Column<double>(type: "float", nullable: true),
                    fldNoSalesReasonID = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "((0))"),
                    fldNotes = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldVisitType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    fldDistanceDifference = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomerVisit", x => x.fldCustomerVisitID);
                    table.ForeignKey(
                        name: "FK_tblCustomerVisit_tblCustomer",
                        column: x => x.fldCustomerID,
                        principalTable: "tblCustomer",
                        principalColumn: "fldCustomerID");
                    table.ForeignKey(
                        name: "FK_tblCustomerVisit_tblNoSalesReason",
                        column: x => x.fldNoSalesReasonID,
                        principalTable: "tblNoSalesReason",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblCustomerVisit_tblRoute",
                        column: x => x.fldRouteID,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblOrder",
                columns: table => new
                {
                    fldOrderID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: true),
                    fldOrderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldOrderType = table.Column<int>(type: "int", nullable: true),
                    fldOrderStatus = table.Column<int>(type: "int", nullable: false),
                    fldOrderDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldOwnerRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldAssignedRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerVisitID = table.Column<long>(type: "bigint", nullable: false),
                    fldTotalSales = table.Column<double>(type: "float", nullable: false),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldNetTotal = table.Column<double>(type: "float", nullable: false),
                    fldVATValue = table.Column<double>(type: "float", nullable: false),
                    fldGrandTotal = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldComments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldPlannedDeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldDeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    fldDeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldCreateUserID = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldLPONumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldPlaceOfSupply = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldPayTerms = table.Column<int>(type: "int", nullable: false),
                    fldDeliveryTerms = table.Column<int>(type: "int", nullable: false),
                    fldDriverId = table.Column<long>(type: "bigint", nullable: true),
                    fldHelperId = table.Column<long>(type: "bigint", nullable: true),
                    fldStockId = table.Column<long>(type: "bigint", nullable: true),
                    fldReceiverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldReceiverMobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerBalance = table.Column<double>(type: "float", nullable: false),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldFurtherTaxValue = table.Column<double>(type: "float", nullable: false),
                    fldPackedById = table.Column<long>(type: "bigint", nullable: true),
                    fldPackingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldPackingComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldPromotionOfferId = table.Column<long>(type: "bigint", nullable: true),
                    fldPayTermsDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldNotes = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldCourierName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldCourierNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCourierComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldDeliveryType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldExtraCharges = table.Column<double>(type: "float", nullable: false),
                    fldIntegrationStatusMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrder", x => x.fldOrderID);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblCustomer",
                        column: x => x.fldCustomerID,
                        principalTable: "tblCustomer",
                        principalColumn: "fldCustomerID");
                    table.ForeignKey(
                        name: "FK_tblOrder_tblRoute",
                        column: x => x.fldOwnerRouteID,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblPlanItem",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldPlanId = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerId = table.Column<long>(type: "bigint", nullable: false),
                    fldSequence = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldTimeWindowStart = table.Column<TimeSpan>(type: "time", nullable: true),
                    fldTimeWindowEnd = table.Column<TimeSpan>(type: "time", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlanItem", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblPlanItem_tblCustomer",
                        column: x => x.fldCustomerId,
                        principalTable: "tblCustomer",
                        principalColumn: "fldCustomerID");
                    table.ForeignKey(
                        name: "FK_tblPlanItem_tblPlan",
                        column: x => x.fldPlanId,
                        principalTable: "tblPlan",
                        principalColumn: "fldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRequest",
                columns: table => new
                {
                    fldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldSubject = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fldRequestType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldStatus = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    fldEmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteId = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    fldDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldComments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldCreateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    fldDeleteDate = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRequest", x => x.fldId);
                    table.ForeignKey(
                        name: "FK_tblRequest_tblCategory",
                        column: x => x.fldCategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "fldId");
                    table.ForeignKey(
                        name: "FK_tblRequest_tblCustomer",
                        column: x => x.fldCustomerId,
                        principalTable: "tblCustomer",
                        principalColumn: "fldCustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblRequest_tblRoute",
                        column: x => x.fldRouteId,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblInvoice",
                columns: table => new
                {
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldInvoiceType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((11))"),
                    fldInvoiceCollectionStatus = table.Column<int>(type: "int", nullable: false),
                    fldInvoiceDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldInvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldSalesInvoiceNumber = table.Column<long>(type: "bigint", nullable: true),
                    fldRefOrderID = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerVisitID = table.Column<long>(type: "bigint", nullable: false),
                    fldPriceBookId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldTotalSales = table.Column<double>(type: "float", nullable: false),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldNetTotal = table.Column<double>(type: "float", nullable: false),
                    fldVATValue = table.Column<double>(type: "float", nullable: false),
                    fldGrandTotal = table.Column<double>(type: "float", nullable: false),
                    fldTotalCollection = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldComments = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldCreateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldLPONumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldPlaceOfSupply = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldPayTerms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldDeliveryTerms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldDriverId = table.Column<long>(type: "bigint", nullable: true),
                    fldHelperId = table.Column<long>(type: "bigint", nullable: true),
                    fldStockId = table.Column<long>(type: "bigint", nullable: true),
                    fldReceiverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fldReceiverMobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldCustomerBalance = table.Column<double>(type: "float", nullable: false),
                    fldDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldSequence = table.Column<int>(type: "int", nullable: true),
                    fldUUID = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    fldHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldIntegrationOrderReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldFurtherTaxValue = table.Column<double>(type: "float", nullable: false),
                    fldPromotionOfferId = table.Column<long>(type: "bigint", nullable: true),
                    fldExtraCharges = table.Column<double>(type: "float", nullable: false),
                    fldGroupPaymentReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldFlag = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldIntegrationStatusMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblInvoice", x => x.fldInvoiceID);
                    table.ForeignKey(
                        name: "FK_tblInvoice_tblCustomer",
                        column: x => x.fldCustomerID,
                        principalTable: "tblCustomer",
                        principalColumn: "fldCustomerID");
                    table.ForeignKey(
                        name: "FK_tblInvoice_tblCustomerVisit",
                        column: x => x.fldCustomerVisitID,
                        principalTable: "tblCustomerVisit",
                        principalColumn: "fldCustomerVisitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblInvoice_tblRoute",
                        column: x => x.fldRouteID,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblPayment",
                columns: table => new
                {
                    fldPaymentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldPaymentCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldInvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldRefInvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    fldAmount = table.Column<double>(type: "float", nullable: false),
                    fldPaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fldPaymentType = table.Column<int>(type: "int", nullable: false),
                    fldCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    fldCustomerVisitID = table.Column<long>(type: "bigint", nullable: true),
                    fldRouteID = table.Column<long>(type: "bigint", nullable: true),
                    fldSalesmanID = table.Column<long>(type: "bigint", nullable: true),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldNotes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    fldChequeNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    fldChequeDate = table.Column<DateTime>(type: "date", nullable: true),
                    fldChequePhotoUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldCollectionStatus = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fldCollectionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldCustomerBalance = table.Column<double>(type: "float", nullable: false),
                    fldBranchId = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldIntegrationPostStatus = table.Column<int>(type: "int", nullable: true),
                    fldIntegrationPostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldRemmitanceBankAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldReceiptMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fldCreateUserID = table.Column<long>(type: "bigint", nullable: true),
                    fldIntegrationStatusMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    fldDiscount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPayment", x => x.fldPaymentID);
                    table.ForeignKey(
                        name: "FK_tblPayment_tblCustomer",
                        column: x => x.fldCustomerID,
                        principalTable: "tblCustomer",
                        principalColumn: "fldCustomerID");
                    table.ForeignKey(
                        name: "FK_tblPayment_tblCustomerVisit",
                        column: x => x.fldCustomerVisitID,
                        principalTable: "tblCustomerVisit",
                        principalColumn: "fldCustomerVisitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPayment_tblRoute",
                        column: x => x.fldRouteID,
                        principalTable: "tblRoute",
                        principalColumn: "fldRouteID");
                });

            migrationBuilder.CreateTable(
                name: "tblOrderLineItem",
                columns: table => new
                {
                    fldID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldOrderID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "('')"),
                    fldSalesQty = table.Column<double>(type: "float", nullable: false),
                    fldOfferQty = table.Column<double>(type: "float", nullable: false),
                    fldPrice = table.Column<double>(type: "float", nullable: false),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldValue = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldTaxValue = table.Column<double>(type: "float", nullable: false),
                    fldNote = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldLastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldTaxCategoryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('SR')"),
                    fldFurtherTaxValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderLineItem", x => x.fldID);
                    table.ForeignKey(
                        name: "FK_tblOrderLineItem_tblOrder",
                        column: x => x.fldOrderID,
                        principalTable: "tblOrder",
                        principalColumn: "fldOrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrderLineItem_tblProduct",
                        column: x => x.fldProductID,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID");
                });

            migrationBuilder.CreateTable(
                name: "tblInvoiceLineItem",
                columns: table => new
                {
                    fldInvoiceLineItemID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldInvoiceID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductID = table.Column<long>(type: "bigint", nullable: false),
                    fldProductUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "('Cur')"),
                    fldQty = table.Column<double>(type: "float", nullable: false),
                    fldOfferQty = table.Column<double>(type: "float", nullable: false),
                    fldReturnQty = table.Column<double>(type: "float", nullable: false),
                    fldPrice = table.Column<double>(type: "float", nullable: false),
                    fldDiscount = table.Column<double>(type: "float", nullable: false),
                    fldTaxValue = table.Column<double>(type: "float", nullable: false),
                    fldValue = table.Column<double>(type: "float", nullable: false),
                    fldCurrencyId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    fldExchangeRate = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    fldCreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    fldNote = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fldIsDamaged = table.Column<bool>(type: "bit", nullable: false),
                    fldBatchId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldSerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fldProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    fldTaxCategoryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('SR')"),
                    fldFurtherTaxValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblInvoiceLineItem", x => x.fldInvoiceLineItemID);
                    table.ForeignKey(
                        name: "FK_tblInvoiceLineItem_tblInvoice",
                        column: x => x.fldInvoiceID,
                        principalTable: "tblInvoice",
                        principalColumn: "fldInvoiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblInvoiceLineItem_tblProduct",
                        column: x => x.fldProductID,
                        principalTable: "tblProduct",
                        principalColumn: "fldProdID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblActivity",
                table: "tblActivity",
                column: "fldName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblActivity_Code",
                table: "tblActivity",
                column: "fldCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblBranch",
                table: "tblBranch",
                column: "fldCode",
                unique: true,
                filter: "[fldCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranch_fldParentId",
                table: "tblBranch",
                column: "fldParentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCategory",
                table: "tblCategory",
                columns: new[] { "fldCode", "fldType" },
                unique: true,
                filter: "[fldCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblCurrency",
                table: "tblCurrency",
                column: "fldSymbol",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_fldAdminAreaID",
                table: "tblCustomer",
                column: "fldAdminAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_fldCategoryId",
                table: "tblCustomer",
                column: "fldCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_fldCurrencyId",
                table: "tblCustomer",
                column: "fldCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_fldPriceBookId",
                table: "tblCustomer",
                column: "fldPriceBookId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_fldRouteID",
                table: "tblCustomer",
                column: "fldRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_fldWorkingAreaID",
                table: "tblCustomer",
                column: "fldWorkingAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerCode",
                table: "tblCustomer",
                column: "fldCustomerCode",
                unique: true,
                filter: "[fldCustomerCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerVisit_fldCustomerID",
                table: "tblCustomerVisit",
                column: "fldCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerVisit_fldNoSalesReasonID",
                table: "tblCustomerVisit",
                column: "fldNoSalesReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerVisit_fldRouteID",
                table: "tblCustomerVisit",
                column: "fldRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployee",
                table: "tblEmployee",
                column: "fldCode",
                unique: true,
                filter: "[fldCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblExpense_fldCategoryId",
                table: "tblExpense",
                column: "fldCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblExpense_fldRouteId",
                table: "tblExpense",
                column: "fldRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvoice_fldCustomerID",
                table: "tblInvoice",
                column: "fldCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvoice_fldCustomerVisitID",
                table: "tblInvoice",
                column: "fldCustomerVisitID");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvoice_fldRouteID",
                table: "tblInvoice",
                column: "fldRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvoice_mobile_code",
                table: "tblInvoice",
                column: "fldInvoiceCode",
                unique: true,
                filter: "[fldInvoiceCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvoiceLineItem_fldInvoiceID",
                table: "tblInvoiceLineItem",
                column: "fldInvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvoiceLineItem_fldProductID",
                table: "tblInvoiceLineItem",
                column: "fldProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_fldCustomerID",
                table: "tblOrder",
                column: "fldCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_fldOwnerRouteID",
                table: "tblOrder",
                column: "fldOwnerRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_MobileCode",
                table: "tblOrder",
                column: "fldOrderCode",
                unique: true,
                filter: "[fldOrderCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderLineItem_fldOrderID",
                table: "tblOrderLineItem",
                column: "fldOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderLineItem_fldProductID",
                table: "tblOrderLineItem",
                column: "fldProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPayment_fldCustomerID",
                table: "tblPayment",
                column: "fldCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPayment_fldCustomerVisitID",
                table: "tblPayment",
                column: "fldCustomerVisitID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPayment_fldRouteID",
                table: "tblPayment",
                column: "fldRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPayment_mobile_code",
                table: "tblPayment",
                column: "fldPaymentCode",
                unique: true,
                filter: "[fldPaymentCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblPlanItem_fldCustomerId",
                table: "tblPlanItem",
                column: "fldCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPlanItem_fldPlanId",
                table: "tblPlanItem",
                column: "fldPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPriceBookEntry",
                table: "tblPriceBookEntry",
                columns: new[] { "fldCurrencyId", "fldPriceBookId", "fldProductId", "fldProductUnit", "fldTier", "fldIsDeleted" },
                unique: true,
                filter: "[fldTier] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblPriceBookEntry_fldPriceBookId",
                table: "tblPriceBookEntry",
                column: "fldPriceBookId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPriceBookEntry_fldProductId",
                table: "tblPriceBookEntry",
                column: "fldProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_fldCategoryID",
                table: "tblProduct",
                column: "fldCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductCode",
                table: "tblProduct",
                column: "fldCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblProductPackage",
                table: "tblProductPackage",
                columns: new[] { "fldProductId", "fldProductUnit" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblProductUnit",
                table: "tblProductUnit",
                column: "fldCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblProductUnit_1",
                table: "tblProductUnit",
                column: "fldName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblPromotionLineItem_fldProductID",
                table: "tblPromotionLineItem",
                column: "fldProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPromotionLineItem_fldPromotionID",
                table: "tblPromotionLineItem",
                column: "fldPromotionID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPurchaseInvoice_fldVendorID",
                table: "tblPurchaseInvoice",
                column: "fldVendorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPurchaseInvoiceLineItem_fldInvoiceID",
                table: "tblPurchaseInvoiceLineItem",
                column: "fldInvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPurchaseInvoiceLineItem_fldProductID",
                table: "tblPurchaseInvoiceLineItem",
                column: "fldProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRequest_fldCategoryId",
                table: "tblRequest",
                column: "fldCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRequest_fldCustomerId",
                table: "tblRequest",
                column: "fldCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRequest_fldRouteId",
                table: "tblRequest",
                column: "fldRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoute_fldSalesmanID",
                table: "tblRoute",
                column: "fldSalesmanID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoute_fldStockID",
                table: "tblRoute",
                column: "fldStockID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoute_fldVanID",
                table: "tblRoute",
                column: "fldVanID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRouteCode",
                table: "tblRoute",
                column: "fldCode",
                unique: true,
                filter: "[fldCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoutePlan_fldPlanId",
                table: "tblRoutePlan",
                column: "fldPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoutePlan_fldRouteId",
                table: "tblRoutePlan",
                column: "fldRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStock",
                table: "tblStock",
                column: "fldCode",
                unique: true,
                filter: "[fldCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblStockDailyBalance",
                table: "tblStockDailyBalance",
                columns: new[] { "ProdID", "Date", "StockID", "fldBatchId" },
                unique: true,
                filter: "[fldBatchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblStockDailyBalance_StockID",
                table: "tblStockDailyBalance",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_tblStockTransactions_fldProdID",
                table: "tblStockTransactions",
                column: "fldProdID");

            migrationBuilder.CreateIndex(
                name: "IX_tblSystemConfig",
                table: "tblSystemConfig",
                columns: new[] { "fldBranchId", "fldConfigKey" },
                unique: true,
                filter: "[fldBranchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblUsername",
                table: "tblUser",
                column: "fldUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblUserPrivilege_fldPrivilegeId",
                table: "tblUserPrivilege",
                column: "fldPrivilegeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVan",
                table: "tblVan",
                column: "fldCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblVan_fldDriverID",
                table: "tblVan",
                column: "fldDriverID");

            migrationBuilder.CreateIndex(
                name: "IX_tblWorkingArea",
                table: "tblWorkingArea",
                column: "fldCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblWorkingArea_fldAdminAreaID",
                table: "tblWorkingArea",
                column: "fldAdminAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblWorkingArea_fldRouteID",
                table: "tblWorkingArea",
                column: "fldRouteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HtblCustomer");

            migrationBuilder.DropTable(
                name: "HtblInvoice");

            migrationBuilder.DropTable(
                name: "HtblInvoiceLineItem");

            migrationBuilder.DropTable(
                name: "HtblPayment");

            migrationBuilder.DropTable(
                name: "HtblStockDailyBalance");

            migrationBuilder.DropTable(
                name: "tblActivity");

            migrationBuilder.DropTable(
                name: "tblAppEvent");

            migrationBuilder.DropTable(
                name: "tblAppPhoto");

            migrationBuilder.DropTable(
                name: "tblAsset");

            migrationBuilder.DropTable(
                name: "tblBankAccount");

            migrationBuilder.DropTable(
                name: "tblBatch");

            migrationBuilder.DropTable(
                name: "tblBranch");

            migrationBuilder.DropTable(
                name: "tblContact");

            migrationBuilder.DropTable(
                name: "tblCurrentLocation");

            migrationBuilder.DropTable(
                name: "tblExpense");

            migrationBuilder.DropTable(
                name: "tblInvoiceLineItem");

            migrationBuilder.DropTable(
                name: "tblJurisdictionPlaceOfSupply");

            migrationBuilder.DropTable(
                name: "tblOdometerReading");

            migrationBuilder.DropTable(
                name: "tblOrderLineItem");

            migrationBuilder.DropTable(
                name: "tblPayment");

            migrationBuilder.DropTable(
                name: "tblPlanItem");

            migrationBuilder.DropTable(
                name: "tblPriceBookEntry");

            migrationBuilder.DropTable(
                name: "tblProductPackage");

            migrationBuilder.DropTable(
                name: "tblProductUnit");

            migrationBuilder.DropTable(
                name: "tblPromotionLineItem");

            migrationBuilder.DropTable(
                name: "tblPurchaseInvoiceLineItem");

            migrationBuilder.DropTable(
                name: "tblRequest");

            migrationBuilder.DropTable(
                name: "tblRoutePlan");

            migrationBuilder.DropTable(
                name: "tblRouteProductCategory");

            migrationBuilder.DropTable(
                name: "tblSalesTarget");

            migrationBuilder.DropTable(
                name: "tblSession");

            migrationBuilder.DropTable(
                name: "tblStockDailyBalance");

            migrationBuilder.DropTable(
                name: "tblStockDailyLoadBalance");

            migrationBuilder.DropTable(
                name: "tblStockTransactions");

            migrationBuilder.DropTable(
                name: "tblSystemConfig");

            migrationBuilder.DropTable(
                name: "tblTaxMatrix");

            migrationBuilder.DropTable(
                name: "tblUserPrivilege");

            migrationBuilder.DropTable(
                name: "tblInvoice");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblPromotionOffer");

            migrationBuilder.DropTable(
                name: "tblPurchaseInvoice");

            migrationBuilder.DropTable(
                name: "tblPlan");

            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblPrivilege");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblCustomerVisit");

            migrationBuilder.DropTable(
                name: "tblCompanyInfo");

            migrationBuilder.DropTable(
                name: "tblCustomer");

            migrationBuilder.DropTable(
                name: "tblNoSalesReason");

            migrationBuilder.DropTable(
                name: "tblCategory");

            migrationBuilder.DropTable(
                name: "tblCurrency");

            migrationBuilder.DropTable(
                name: "tblPriceBook");

            migrationBuilder.DropTable(
                name: "tblWorkingArea");

            migrationBuilder.DropTable(
                name: "tblAdminArea");

            migrationBuilder.DropTable(
                name: "tblRoute");

            migrationBuilder.DropTable(
                name: "tblStock");

            migrationBuilder.DropTable(
                name: "tblVan");

            migrationBuilder.DropTable(
                name: "tblEmployee");
        }
    }
}
