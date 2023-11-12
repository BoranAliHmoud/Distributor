using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblVan")]
[Index("FldCode", Name = "IX_tblVan", IsUnique = true)]
public partial class TblVan
{
    [Key]
    [Column("fldVanID")]
    public long FldVanId { get; set; }

    [Column("fldName")]
    [StringLength(400)]
    public string FldName { get; set; } = null!;

    [Column("fldDriverID")]
    public long? FldDriverId { get; set; }

    [Column("fldPlateNumber")]
    [StringLength(100)]
    public string FldPlateNumber { get; set; } = null!;

    [Column("fldPurchaseDate", TypeName = "datetime")]
    public DateTime? FldPurchaseDate { get; set; }

    [Column("fldType")]
    [StringLength(50)]
    public string? FldType { get; set; }

    [Column("fldModelYear")]
    public int? FldModelYear { get; set; }

    [Column("fldChassisNumber")]
    [StringLength(50)]
    public string? FldChassisNumber { get; set; }

    [Column("fldRegisterationDate", TypeName = "datetime")]
    public DateTime? FldRegisterationDate { get; set; }

    [Column("fldExpirationDate", TypeName = "datetime")]
    public DateTime? FldExpirationDate { get; set; }

    [Column("fldInsuranceExpriyDate", TypeName = "datetime")]
    public DateTime? FldInsuranceExpriyDate { get; set; }

    [Column("fldInsuranceCompany")]
    [StringLength(200)]
    public string? FldInsuranceCompany { get; set; }

    [Column("fldTrafficCode")]
    [StringLength(50)]
    public string? FldTrafficCode { get; set; }

    [Column("fldVolume")]
    public double? FldVolume { get; set; }

    [Column("fldWeight")]
    public double? FldWeight { get; set; }

    [Column("fldDescription")]
    [StringLength(512)]
    public string? FldDescription { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [ForeignKey("FldDriverId")]
    [InverseProperty("TblVans")]
    public virtual TblEmployee? FldDriver { get; set; }

    [InverseProperty("FldVan")]
    public virtual ICollection<TblRoute> TblRoutes { get; set; } = new List<TblRoute>();
}
