using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblEmployee")]
[Index("FldCode", Name = "IX_tblEmployee", IsUnique = true)]
public partial class TblEmployee
{
    [Key]
    [Column("fldEmpID")]
    public long FldEmpId { get; set; }

    [Column("fldName")]
    [StringLength(200)]
    public string FldName { get; set; } = null!;

    [Column("fldLastName")]
    [StringLength(200)]
    public string? FldLastName { get; set; }

    [Column("fldPosition")]
    [StringLength(50)]
    public string? FldPosition { get; set; }

    [Column("fldManagerID")]
    public long? FldManagerId { get; set; }

    [Column("fldBirthday", TypeName = "datetime")]
    public DateTime? FldBirthday { get; set; }

    [Column("fldMobilePhone")]
    [StringLength(50)]
    public string? FldMobilePhone { get; set; }

    [Column("fldLandLine")]
    [StringLength(50)]
    public string? FldLandLine { get; set; }

    [Column("fldAddress")]
    [StringLength(400)]
    public string? FldAddress { get; set; }

    [Column("fldNationality")]
    [StringLength(50)]
    public string? FldNationality { get; set; }

    [Column("fldNationalNumber")]
    [StringLength(400)]
    public string? FldNationalNumber { get; set; }

    [Column("fldLicenseNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldLicenseNumber { get; set; }

    [Column("fldLicenseDate", TypeName = "datetime")]
    public DateTime? FldLicenseDate { get; set; }

    [Column("fldEmploymentDate", TypeName = "datetime")]
    public DateTime? FldEmploymentDate { get; set; }

    [Column("fldNote", TypeName = "text")]
    public string? FldNote { get; set; }

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

    [Column("fldRole")]
    public int? FldRole { get; set; }

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldUserId")]
    public long? FldUserId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [InverseProperty("FldSalesman")]
    public virtual ICollection<TblRoute> TblRoutes { get; set; } = new List<TblRoute>();

    [InverseProperty("FldDriver")]
    public virtual ICollection<TblVan> TblVans { get; set; } = new List<TblVan>();
}
