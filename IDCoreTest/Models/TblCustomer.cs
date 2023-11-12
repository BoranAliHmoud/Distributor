using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblCustomer")]
[Index("FldCustomerCode", Name = "IX_tblCustomerCode", IsUnique = true)]
public partial class TblCustomer
{
    [Key]
    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldCustomerCode")]
    [StringLength(100)]
    public string? FldCustomerCode { get; set; }

    [Column("fldAdminAreaID")]
    public long FldAdminAreaId { get; set; }

    [Column("fldWorkingAreaID")]
    public long FldWorkingAreaId { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldActivityID")]
    public long FldActivityId { get; set; }

    [Column("fldCategoryId")]
    public long FldCategoryId { get; set; }

    [Column("fldTranslatedName")]
    [StringLength(255)]
    public string? FldTranslatedName { get; set; }

    [Column("fldName")]
    [StringLength(255)]
    public string FldName { get; set; } = null!;

    [Column("fldContactPerson")]
    [StringLength(200)]
    public string? FldContactPerson { get; set; }

    [Column("fldNationalNumber")]
    [StringLength(50)]
    public string? FldNationalNumber { get; set; }

    [Column("fldAddress")]
    [StringLength(200)]
    public string? FldAddress { get; set; }

    [Column("fldMobilePhone")]
    [StringLength(50)]
    public string? FldMobilePhone { get; set; }

    [Column("fldTelephone")]
    [StringLength(50)]
    public string? FldTelephone { get; set; }

    [Column("fldOtherTelephone")]
    [StringLength(50)]
    public string? FldOtherTelephone { get; set; }

    [Column("fldCurrentBalance")]
    public double FldCurrentBalance { get; set; }

    [Column("fldCreditLimit")]
    public int FldCreditLimit { get; set; }

    [Column("fldMaxDiscount")]
    public double FldMaxDiscount { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldPriceBookId")]
    public long FldPriceBookId { get; set; }

    [Column("fldLongitude")]
    public double? FldLongitude { get; set; }

    [Column("fldLatitude")]
    public double? FldLatitude { get; set; }

    [Column("fldZoomLevel")]
    public double FldZoomLevel { get; set; }

    [Required]
    [Column("fldIsVisible")]
    public bool? FldIsVisible { get; set; }

    [Column("fldWorkingHours")]
    [StringLength(200)]
    public string? FldWorkingHours { get; set; }

    [Column("fldServiceTime")]
    public double FldServiceTime { get; set; }

    [Column("fldEmail")]
    [StringLength(50)]
    public string? FldEmail { get; set; }

    [Column("fldTRN")]
    [StringLength(40)]
    public string? FldTrn { get; set; }

    [Column("fldComments")]
    [StringLength(200)]
    public string? FldComments { get; set; }

    [Column("fldVisitWeek")]
    [StringLength(5)]
    public string? FldVisitWeek { get; set; }

    [Column("fldVisitDay")]
    [StringLength(7)]
    public string? FldVisitDay { get; set; }

    [Column("fldLicenseNumber")]
    [StringLength(50)]
    public string? FldLicenseNumber { get; set; }

    [Column("fldAccessChannel")]
    public long? FldAccessChannel { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldCreateEmployeeID")]
    public long? FldCreateEmployeeId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldPOBox")]
    [StringLength(15)]
    public string? FldPobox { get; set; }

    [Column("fldDefaultDiscount")]
    public double FldDefaultDiscount { get; set; }

    [Column("fldCreditDays")]
    public int FldCreditDays { get; set; }

    [Column("fldCreditCategory")]
    public int FldCreditCategory { get; set; }

    [Column("fldLicenseExpiryDate", TypeName = "datetime")]
    public DateTime? FldLicenseExpiryDate { get; set; }

    [Column("fldPlaceOfSupply")]
    [StringLength(50)]
    public string? FldPlaceOfSupply { get; set; }

    [Column("fldFax")]
    [StringLength(50)]
    public string? FldFax { get; set; }

    [Column("fldWebsite")]
    [StringLength(150)]
    public string? FldWebsite { get; set; }

    [Column("fldCustomerType")]
    public int FldCustomerType { get; set; }

    [Column("fldIntegrationPartyId")]
    [StringLength(50)]
    public string? FldIntegrationPartyId { get; set; }

    [Column("fldIntegrationBillSiteId")]
    [StringLength(50)]
    public string? FldIntegrationBillSiteId { get; set; }

    [Column("fldIntegrationAccountId")]
    [StringLength(50)]
    public string? FldIntegrationAccountId { get; set; }

    [Column("fldIntegrationShipSiteId")]
    [StringLength(50)]
    public string? FldIntegrationShipSiteId { get; set; }

    [Column("fldIntegrationSiteAddressNumber")]
    [StringLength(50)]
    public string? FldIntegrationSiteAddressNumber { get; set; }

    [Column("fldIntegrationAddressId")]
    [StringLength(50)]
    public string? FldIntegrationAddressId { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldLastVisitDate", TypeName = "datetime")]
    public DateTime? FldLastVisitDate { get; set; }

    [Column("fldLastVisitResult")]
    public int? FldLastVisitResult { get; set; }

    [Column("fldLastCreditInvoiceDate", TypeName = "datetime")]
    public DateTime? FldLastCreditInvoiceDate { get; set; }

    [Column("fldShipToAddress")]
    [StringLength(512)]
    public string? FldShipToAddress { get; set; }

    [Column("fldShipToName")]
    [StringLength(255)]
    public string? FldShipToName { get; set; }

    [Column("fldShipToTel")]
    [StringLength(50)]
    public string? FldShipToTel { get; set; }

    [Column("fldShipToEmail")]
    [StringLength(150)]
    public string? FldShipToEmail { get; set; }

    [Column("fldInitialBalance")]
    public double FldInitialBalance { get; set; }

    [Column("fldCnic")]
    [StringLength(50)]
    public string? FldCnic { get; set; }

    [Column("fldNtn")]
    [StringLength(50)]
    public string? FldNtn { get; set; }

    [Column("fldIsConsignment")]
    public bool FldIsConsignment { get; set; }

    [Column("fldPayTerms")]
    public int FldPayTerms { get; set; }

    [Column("fldGroup")]
    [StringLength(200)]
    public string? FldGroup { get; set; }

    [Column("fldAccountStatus")]
    public int FldAccountStatus { get; set; }

    [Column("fldIsGroup")]
    public bool FldIsGroup { get; set; }

    [Column("fldIntegrationStatusMessage")]
    [StringLength(512)]
    public string? FldIntegrationStatusMessage { get; set; }

    [ForeignKey("FldAdminAreaId")]
    [InverseProperty("TblCustomers")]
    public virtual TblAdminArea FldAdminArea { get; set; } = null!;

    [ForeignKey("FldCategoryId")]
    [InverseProperty("TblCustomers")]
    public virtual TblCategory FldCategory { get; set; } = null!;

    [ForeignKey("FldCurrencyId")]
    [InverseProperty("TblCustomers")]
    public virtual TblCurrency FldCurrency { get; set; } = null!;

    [ForeignKey("FldPriceBookId")]
    [InverseProperty("TblCustomers")]
    public virtual TblPriceBook FldPriceBook { get; set; } = null!;

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblCustomers")]
    [JsonIgnore]
    public virtual TblRoute? FldRoute { get; set; }

    [ForeignKey("FldWorkingAreaId")]
    [InverseProperty("TblCustomers")]
    public virtual TblWorkingArea FldWorkingArea { get; set; } = null!;

    [InverseProperty("FldCustomer")]
    public virtual ICollection<TblCustomerVisit> TblCustomerVisits { get; set; } = new List<TblCustomerVisit>();

    [InverseProperty("FldCustomer")]
    public virtual ICollection<TblInvoice> TblInvoices { get; set; } = new List<TblInvoice>();

    [InverseProperty("FldCustomer")]
    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();

    [InverseProperty("FldCustomer")]
    public virtual ICollection<TblPayment> TblPayments { get; set; } = new List<TblPayment>();

    [InverseProperty("FldCustomer")]
    public virtual ICollection<TblPlanItem> TblPlanItems { get; set; } = new List<TblPlanItem>();

    [InverseProperty("FldCustomer")]
    public virtual ICollection<TblRequest> TblRequests { get; set; } = new List<TblRequest>();
    [DataMember]
    public String FullName
    {
        get
        {
            return FldCustomerId + " - " + FldName;
           
        }
    }
    [DataMember]
    public String RouteName
    {
        get
        {
            if (FldRoute != null)
                return FldRoute.FldRouteName;
            return null;
        }
    }
}
