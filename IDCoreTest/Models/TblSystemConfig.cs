using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblSystemConfig")]
[Index("FldBranchId", "FldConfigKey", Name = "IX_tblSystemConfig", IsUnique = true)]
public partial class TblSystemConfig
{
    [Key]
    [Column("fldId")]
    public int FldId { get; set; }

    [Column("fldConfigKey")]
    [StringLength(50)]
    public string FldConfigKey { get; set; } = null!;

    [Column("fldConfigValue")]
    [StringLength(255)]
    public string FldConfigValue { get; set; } = null!;

    [Column("fldDescription")]
    [StringLength(512)]
    public string? FldDescription { get; set; }

    [Column("fldValueType")]
    public int? FldValueType { get; set; }

    [Column("fldMinValue")]
    public double? FldMinValue { get; set; }

    [Column("fldMaxValue")]
    public double? FldMaxValue { get; set; }

    [Column("fldStepValue")]
    public double? FldStepValue { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldTranslatedDescription")]
    [StringLength(512)]
    public string? FldTranslatedDescription { get; set; }
}
