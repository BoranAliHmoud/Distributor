using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("HtblCustomer")]
public partial class HtblCustomer
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldCustomerCode")]
    [StringLength(100)]
    public string? FldCustomerCode { get; set; }

    [Column("fldWorkingAreaID")]
    public long FldWorkingAreaId { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldAltRouteId")]
    public long? FldAltRouteId { get; set; }

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

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldPriceBookId")]
    public long FldPriceBookId { get; set; }

    [Column("fldLongitude")]
    public double? FldLongitude { get; set; }

    [Column("fldLatitude")]
    public double? FldLatitude { get; set; }

    [Column("fldLicenseNumber")]
    [StringLength(50)]
    public string? FldLicenseNumber { get; set; }

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

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldAccessChannel")]
    public long? FldAccessChannel { get; set; }

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
}
