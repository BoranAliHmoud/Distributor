using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPlanItem")]
public partial class TblPlanItem
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldPlanId")]
    public long FldPlanId { get; set; }

    [Column("fldCustomerId")]
    public long FldCustomerId { get; set; }

    [Column("fldSequence")]
    public int FldSequence { get; set; }

    [Column("fldTimeWindowStart")]
    public TimeSpan? FldTimeWindowStart { get; set; }

    [Column("fldTimeWindowEnd")]
    public TimeSpan? FldTimeWindowEnd { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [ForeignKey("FldCustomerId")]
    [InverseProperty("TblPlanItems")]
    public virtual TblCustomer FldCustomer { get; set; } = null!;

    [ForeignKey("FldPlanId")]
    [InverseProperty("TblPlanItems")]
    public virtual TblPlan FldPlan { get; set; } = null!;
}
