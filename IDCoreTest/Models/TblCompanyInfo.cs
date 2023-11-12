using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblCompanyInfo")]
public partial class TblCompanyInfo
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldName")]
    [StringLength(200)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(200)]
    public string? FldTranslatedName { get; set; }

    [Column("fldAddress")]
    [StringLength(500)]
    public string? FldAddress { get; set; }

    [Column("fldTelephone")]
    [StringLength(50)]
    public string? FldTelephone { get; set; }

    [Column("fldMobile")]
    [StringLength(50)]
    public string? FldMobile { get; set; }

    [Column("fldFax")]
    [StringLength(50)]
    public string? FldFax { get; set; }

    [Column("fldEmail")]
    [StringLength(100)]
    public string? FldEmail { get; set; }

    [Column("fldWebsite")]
    [StringLength(255)]
    public string? FldWebsite { get; set; }

    [Column("fldLogoUrl")]
    [StringLength(500)]
    public string? FldLogoUrl { get; set; }

    [Column("fldContactName")]
    [StringLength(255)]
    public string? FldContactName { get; set; }

    [Column("fldTaxRegisterationNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FldTaxRegisterationNumber { get; set; }

    [Column("fldTaxPercentage")]
    public double FldTaxPercentage { get; set; }

    [Column("fldLicenseNumber")]
    [StringLength(50)]
    public string? FldLicenseNumber { get; set; }

    [Column("fldLicenseExpiryDate", TypeName = "datetime")]
    public DateTime? FldLicenseExpiryDate { get; set; }

    [Column("fldConfigVersion")]
    public int FldConfigVersion { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldRegistrationCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldRegistrationCode { get; set; }

    [Column("fldIDMLicenses")]
    public int FldIdmlicenses { get; set; }

    [Column("fldIDVLicenses")]
    public int FldIdvlicenses { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCountryId")]
    public long? FldCountryId { get; set; }

    [Column("fldJurisdiction")]
    [StringLength(50)]
    public string? FldJurisdiction { get; set; }

    [Column("fldBaseUrl")]
    [StringLength(500)]
    public string? FldBaseUrl { get; set; }

    [Column("fldInvoiceReportTemplate")]
    [StringLength(255)]
    public string? FldInvoiceReportTemplate { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationkey")]
    [StringLength(150)]
    public string? FldIntegrationkey { get; set; }

    [Column("fldIntegrationUsername")]
    [StringLength(150)]
    public string? FldIntegrationUsername { get; set; }

    [Column("fldIntegrationPassword")]
    [StringLength(150)]
    public string? FldIntegrationPassword { get; set; }

    [Column("fldRegistrationStartDate", TypeName = "datetime")]
    public DateTime? FldRegistrationStartDate { get; set; }

    [Column("fldRegistrationEndDate", TypeName = "datetime")]
    public DateTime? FldRegistrationEndDate { get; set; }

    [Column("fldOrderReportTemplate")]
    [StringLength(255)]
    public string? FldOrderReportTemplate { get; set; }

    [InverseProperty("FldVendor")]
    public virtual ICollection<TblPurchaseInvoice> TblPurchaseInvoices { get; set; } = new List<TblPurchaseInvoice>();
}
