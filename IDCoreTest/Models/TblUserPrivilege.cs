using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[PrimaryKey("FldUserId", "FldPrivilegeId")]
[Table("tblUserPrivilege")]
public partial class TblUserPrivilege
{
    [Key]
    [Column("fldUserId")]
    public long FldUserId { get; set; }

    [Key]
    [Column("fldPrivilegeId")]
    public long FldPrivilegeId { get; set; }

    [Column("fldCreationDate", TypeName = "datetime")]
    public DateTime FldCreationDate { get; set; }

    [ForeignKey("FldPrivilegeId")]
    [InverseProperty("TblUserPrivileges")]
    public virtual TblPrivilege FldPrivilege { get; set; } = null!;

    [ForeignKey("FldUserId")]
    [InverseProperty("TblUserPrivileges")]
    public virtual TblUser FldUser { get; set; } = null!;
}
