using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblBranch")]
[Index("FldCode", Name = "IX_tblBranch", IsUnique = true)]
public partial class TblBranch
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(255)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(255)]
    public string? FldTranslatedName { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldManager")]
    [StringLength(50)]
    public string? FldManager { get; set; }

    [Column("fldAddress")]
    [StringLength(50)]
    public string? FldAddress { get; set; }

    [Column("fldTelephone")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldTelephone { get; set; }

    [Column("fldDescription")]
    [StringLength(255)]
    public string? FldDescription { get; set; }

    [Column("fldParentId")]
    public long? FldParentId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldMobile")]
    [StringLength(50)]
    public string? FldMobile { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Column("fldEmail")]
    [StringLength(100)]
    public string? FldEmail { get; set; }

    [Column("fldJurisdiction")]
    [StringLength(50)]
    public string? FldJurisdiction { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldTaxRegisterationNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FldTaxRegisterationNumber { get; set; }

    [Column("fldLicenseNumber")]
    [StringLength(50)]
    public string? FldLicenseNumber { get; set; }

    [Column("fldIDMLicenses")]
    public int FldIdmlicenses { get; set; }

    [Column("fldIDVLicenses")]
    public int FldIdvlicenses { get; set; }

    [Column("fldIntegrationTransactionTypeReturnCode")]
    [StringLength(50)]
    public string? FldIntegrationTransactionTypeReturnCode { get; set; }

    [Column("fldIntegrationTransactionTypeSalesCode")]
    [StringLength(50)]
    public string? FldIntegrationTransactionTypeSalesCode { get; set; }

    [Column("fldBankAccount")]
    [StringLength(50)]
    public string? FldBankAccount { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldInvoiceReportTemplate")]
    [StringLength(255)]
    public string? FldInvoiceReportTemplate { get; set; }

    [Column("fldOrderReportTemplate")]
    [StringLength(255)]
    public string? FldOrderReportTemplate { get; set; }

    [ForeignKey("FldParentId")]
    [InverseProperty("InverseFldParent")]
    public virtual TblBranch? FldParent { get; set; }

    [InverseProperty("FldParent")]
    public virtual ICollection<TblBranch> InverseFldParent { get; set; } = new List<TblBranch>();
}
