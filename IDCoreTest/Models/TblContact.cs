using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblContact")]
public partial class TblContact
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Column("fldName")]
    [StringLength(50)]
    public string FldName { get; set; } = null!;

    [Column("fldLastName")]
    [StringLength(50)]
    public string? FldLastName { get; set; }

    [Column("fldCustomerId")]
    public long? FldCustomerId { get; set; }

    [Column("fldPosition")]
    [StringLength(50)]
    public string? FldPosition { get; set; }

    [Column("fldDepartment")]
    [StringLength(50)]
    public string? FldDepartment { get; set; }

    [Column("fldMobile")]
    [StringLength(50)]
    public string? FldMobile { get; set; }

    [Column("fldContactEmail")]
    [StringLength(100)]
    public string? FldContactEmail { get; set; }

    [Column("fldAddress")]
    [StringLength(200)]
    public string? FldAddress { get; set; }

    [Column("fldTelephone")]
    [StringLength(50)]
    public string? FldTelephone { get; set; }

    [Column("fldGender")]
    public int FldGender { get; set; }

    [Column("fldBirthDate", TypeName = "datetime")]
    public DateTime? FldBirthDate { get; set; }

    [Column("fldHasAccessPortal")]
    public bool FldHasAccessPortal { get; set; }

    [Column("fldPortalPassword")]
    [StringLength(50)]
    public string? FldPortalPassword { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateUserId")]
    public long? FldCreateUserId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }
}
