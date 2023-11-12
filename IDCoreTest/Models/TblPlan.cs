using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPlan")]
public partial class TblPlan
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(255)]
    public string FldName { get; set; } = null!;

    [Column("fldDescription")]
    [StringLength(500)]
    public string? FldDescription { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

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

    [InverseProperty("FldPlan")]
    public virtual ICollection<TblPlanItem> TblPlanItems { get; set; } = new List<TblPlanItem>();

    [InverseProperty("FldPlan")]
    public virtual ICollection<TblRoutePlan> TblRoutePlans { get; set; } = new List<TblRoutePlan>();
}
