using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblUser")]
[Index("FldUserName", Name = "IX_tblUsername", IsUnique = true)]
public partial class TblUser
{
    [Key]
    [Column("fldUserID")]
    public long FldUserId { get; set; }

    [Column("fldUserName")]
    [StringLength(50)]
    public string FldUserName { get; set; } = null!;

    [Column("fldPassword")]
    [StringLength(50)]
    public string FldPassword { get; set; } = null!;

    [Column("fldIsActive")]
    public bool FldIsActive { get; set; }

    [Column("fldActivationKey")]
    [StringLength(50)]
    public string? FldActivationKey { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldUserType")]
    [StringLength(5)]
    [Unicode(false)]
    public string FldUserType { get; set; } = null!;

    [Column("fldDepartment")]
    [StringLength(50)]
    public string? FldDepartment { get; set; }

    [Column("fldEmail")]
    [StringLength(200)]
    public string? FldEmail { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldSessionLifeTime")]
    public double FldSessionLifeTime { get; set; }

    [Column("fldAllowedDistance")]
    public double? FldAllowedDistance { get; set; }

    [Column("fldRole")]
    [StringLength(50)]
    public string? FldRole { get; set; }

    [InverseProperty("FldUser")]
    public virtual ICollection<TblUserPrivilege> TblUserPrivileges { get; set; } = new List<TblUserPrivilege>();
}
