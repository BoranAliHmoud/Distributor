using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblActivity")]
[Index("FldName", Name = "IX_tblActivity", IsUnique = true)]
[Index("FldCode", Name = "IX_tblActivity_Code", IsUnique = true)]
public partial class TblActivity
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(250)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(250)]
    public string? FldTranslatedName { get; set; }

    [Column("fldGooglePlaceType")]
    [StringLength(250)]
    public string? FldGooglePlaceType { get; set; }

    [Column("fldDisplayOrder")]
    public int FldDisplayOrder { get; set; }

    [Column("fldIcon")]
    [StringLength(400)]
    public string? FldIcon { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;
}
