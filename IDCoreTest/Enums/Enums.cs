namespace IDCoreTest 
{
    public enum ORFCOrderStatus
    {
        New = 1,
        UpdateShipmentLine = 2,
        CreateShipment = 3,
        ConfirmShipment = 4,
        Billed = 5
    }
    public enum IntegrationOperationType
    {
        Insert = 1,
        Update = 2,
        Delete = 3,

    }
    public enum PricingModels
    {
        Standard = 1,
        Package = 2,
        Gradudated = 3,
        Volume = 4
    }
    public enum CustomerType
    {
        Business = 1,
        Person = 2,
        Household = 3
    }

    public enum CustomerCreditCategory
    {
        Immediate = 1,
        EndOfMonth = 2
    }

    public enum AreaType
    {
        PlaceOfSupplyOrJurisdiction = 1,
        PlaceOfSupply = 2,
        Jurisdiction = 3
    }

    public enum RoutePlanType
    {
        OneTime = 1,
        Daily = 2,
        Weekly = 3,
        Monthly = 4
    }

    public enum PrintingPaperSize
    {
        FourInch = 832,
        TwoInch = 384,
        ThreeInch = 576
    }

    public enum PrintingLanguage
    {
        En = 1,
        Ar = 2,
        UserChoice = 3
    }

    public enum PrintDocumentType
    {
        CurrentStockReport = 1,
        LoadRequestsReport = 2,
        InvoiceDocument = 10,
        OrderDocument = 13,
        ReceiptDocument = 20,
        SalesmanReport = 30,

    }

    public enum LicenseType
    {
        IDM = 1,
        IDV = 2
    }

    public enum LicenseStatus
    {
        Active = 1,
        Inactive = 2
    }

    public enum IDVErrorCodes
    {
        Success = 0,
        NullRoute = 1,
        Exception = 2,
        PartialSuccess = 3,
        Failure = 4,
        UpdateApp = 101,
        NoUpdateRequired = 102,
        LicenseAboutExpire = 103,
        LicenseExpiredNoticePeriod = 104,
        LicenseExpired = 105,
        UniqueKeyViolation = 2627,
        PrimaryKeyViolation = 2601,
        ForeignKeyViolation = 547
    }

    public enum InvoiceType
    {
        Cash = 11,
        Credit = 10,
        Return = 12,
        Order = 13,
        Gift = 14

    }

    public enum CollectionStatus
    {
        Paid = 3,
        Partially = 2,
        Unpaid = 1
    }

    public enum VisitType
    {
        Inactive = 0,
        ActiveInvoiceCash = 1,
        ActiveInvoiceCredit = 2,
        ActiveOrder = 3,
        ActiveCollectPayment = 4,

        ActiveReturn = 5,
        ActiveDeliver = 6,
        ActiveGift = 7,
        ActiveReplacement = 8,
        ActiveReturnPayment = 9,
        Incomplete = -1
    }
    public enum NoSalesReasons
    {
        HasStock = 1,
        PriceProblem = 2,
        QualityProblem = 3,
        BuyFromCompetitor = 4,
        BuyFromDealer = 5,
        Closed = 6,
        CollectPayment = 7,
        FirstVisit = 8,
        ReturnInvoice = 9,
        ReturnPayment = 10,
    }
    public enum PaymentType
    {
        ChequeForCreditInvoice = 11,
        ChequeForCashInvoice = 12,
        ChequeForReturn = 13,
        ChequeForBalance = 14,

        CashForCreditInvoice = 21,
        CashForCashInvoice = 22,
        CashForReturn = 23,
        CashForBalance = 24,

        CardForCreditInvoice = 31,
        CardForCashInvoice = 32,
        CardForReturn = 33,
        CardForBalance = 34,

        BankTransferForCreditInvoice = 41,
        BankTransferForCashInvoice = 42,
        BankTransferForReturn = 43,
        BankTransferForBalance = 44,

        VoucherForCreditInvoice = 51,
        VoucherForCashInvoice = 52,
        VoucherForBalance = 54,
    }

    public enum OrderStatus
    {
        New = 1, //DRAFT
        ReadyForShipment = 2, //PREPARATION
        ReadyForBilling = 3, //DISPATCHED
        Delivered = 4, //DELIVERED
        Canceled = 5
    }

    public enum OrderType
    {
        Standard = 1,
        Gift = 2,
        Consignment = 3,

    }

    public enum PurchaseInvoiceLoadStatus
    {
        NotLoaded = 1,
        Loaded = 2
    }

    public enum PromotionOfferType
    {
        SpecificProductQuantity = 1,
        TotalSales = 2,
        ItemTotalSales = 3,
        MixProductQuantity = 4

    }

    public enum PromotionOfferStatus
    {
        Active = 1,
        Inactive = 2
    }

    public enum PromotionItemType
    {
        BuyQty = 10,
        BuyValue = 11,
        GetQty = 20,
        GetDiscount = 21
    }

    public enum StockType
    {
        Warehouse = 1,
        Van = 2
    }

    public enum GetStockRecordsType
    {
        Today = 1,
        Any = 2,
        AnyExceptToday = 3
    }

    public enum StockTransactionType
    {
        Purchase = 1,
        Load = 2,
        OffLoad = 3,
        Adjust = 4,
        Damage = 5,
        Transfer = 6,
        SetBalance = 7,
        Sell = 8,
        Return = 9,
        Resell = 10,
        Offer = 11,

        //TransferIn = 6,

        Relay = 12,
        OffloadDamage = 13
    }

    public enum StockReplacementReason
    {
        AboutToExpire = 1,
        Expired = 2,
        Damaged = 3,
        Normal = 4
    }

    public enum CompanyType
    {
        Self = 1,
        Vendor = 2
    }

    public enum AppEventType
    {
        PrintInvoice = 1,
        PrintPayment = 2,
        LunchBreak = 3,
        Breakdown = 4,
        Leave = 5,
        ExternalTask = 6,
        Other = 7,
    }

    public enum AppPhotoType
    {
        VisitPhoto = 1,
        VisitBeforePhoto = 11,
        VisitDuringPhoto = 12,
        VisitAfterPhoto = 13,


        ProductPhoto = 2,
        PromotionOfferPhoto = 21,

        CustomerPhoto = 3,
        TradeLicensePhoto = 31,
        TaxCertificatePhoto = 32,
        PassportPhoto = 33, // BUSINESS OWNER PASSPORT  BUSINESS SPONSOR PASSPORT
        IDPhoto = 34, // COMPANY BUSINESS CARD
        SignboardPhoto = 35,
        AgreementPhoto = 36,//APPLICATION FORM

        AssetPhoto = 37,
        VisaPhoto = 38, // BUSINESS OWNER / BUSINESS SPONSOR  VISA
        OtherPhoto = 39,// NOC LETTER - LPO


        CompanyLogo = 4,
        ProductCategoryPhoto = 5,
        InvoicePhoto = 6,
        PaymentPhoto = 7,
        PaymentChequePhoto = 71,
        ExpensePhoto = 8,
        OrderPhoto = 9,
        //VanPhoto = 9,
        EmployeePhoto = 10,

        SignaturePhoto = 61,

        AssetActivePhoto = 371,
        AssetInactivePhoto = 372,
        AssetUnderMaintenancePhoto = 373,
        AssetHasIssuePhoto = 374,
        //VisitAssetPhoto = 14,

    }

    public enum CategoryType
    {
        CustomerCategory = 1,
        ProductCategory = 2,
        ExpenseCategory = 3,
        AccessChannelCategory = 4,
        CustomerAccountType = 5,
        AssetCategory = 6,
        ComplaintCategory = 7,
    }

    public enum AssetStatus
    {
        New = 37,
        Active = 371,
        Inactive = 372,
        UnderMaintenance = 373,
        HasIssue = 374,
    }

    public enum DiscountType
    {
        Value = 1,
        Percentage = 2
    }
    public enum InvoiceDataErrorType
    {
        PriceIssue = 1,
        UnitIssue = 2,
        QuantityIssue = 3
    }

    public enum PaymentTerms
    {
        AdvancePaymentCash = 1,
        AdvancePaymentCheque = 2,
        AdvancePaymentNEFTOrRTGS = 3,
        AdvancePaymentCard = 4,
        AdvancePaymentGPayUPI = 5,
        CashOnDeliveryCash = 6,
        CashOnDeliveryCheque = 7,
        CashOnDeliveryNEFTOrRTGS = 8,
        CashOnDeliveryCard = 9,
        CashOnDeliveryGPayUPI = 10,
        CreditTerm = 11

    }

    public enum CheckUserRegistrationStatus
    {
        Exist = 0,
        NotExist = 1

    }
    public enum ApplicationTypes
    {
        JavaScript = 1,
        NativeConfidential = 2,
        Order = 3
    };
}
