using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblJurisdictionPlaceOfSupply")]
public partial class TblJurisdictionPlaceOfSupply
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldName")]
    [StringLength(200)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(200)]
    public string? FldTranslatedName { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime? FldCreateDate { get; set; }
}
