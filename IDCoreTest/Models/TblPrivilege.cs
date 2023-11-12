using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPrivilege")]
public partial class TblPrivilege
{
    [Key]
    [Column("fldPrivilegeID")]
    public long FldPrivilegeId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldName")]
    [StringLength(150)]
    public string FldName { get; set; } = null!;

    [Column("fldTName")]
    [StringLength(150)]
    public string? FldTname { get; set; }

    [Column("fldDescription")]
    [StringLength(300)]
    public string? FldDescription { get; set; }

    [Column("fldTDescription")]
    [StringLength(300)]
    public string? FldTdescription { get; set; }

    [Column("fldGroupId")]
    public int? FldGroupId { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [InverseProperty("FldPrivilege")]
    public virtual ICollection<TblUserPrivilege> TblUserPrivileges { get; set; } = new List<TblUserPrivilege>();
}
