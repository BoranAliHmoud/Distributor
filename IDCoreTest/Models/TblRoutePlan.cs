using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblRoutePlan")]
public partial class TblRoutePlan
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldRouteId")]
    public long FldRouteId { get; set; }

    [Column("fldPlanId")]
    public long FldPlanId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldComments")]
    [StringLength(500)]
    public string? FldComments { get; set; }

    [Column("fldStartDate", TypeName = "datetime")]
    public DateTime? FldStartDate { get; set; }

    [Column("fldEndDate", TypeName = "datetime")]
    public DateTime? FldEndDate { get; set; }

    [Column("fldRecurrence")]
    public int FldRecurrence { get; set; }

    [Column("fldVisitWeekPattern")]
    [StringLength(5)]
    public string? FldVisitWeekPattern { get; set; }

    [Column("fldVisitDayPattern")]
    [StringLength(7)]
    public string? FldVisitDayPattern { get; set; }

    [Column("fldVisitMonthPattern")]
    [StringLength(12)]
    public string? FldVisitMonthPattern { get; set; }

    [Column("fldVisitMonthDaysPattern")]
    [StringLength(31)]
    public string? FldVisitMonthDaysPattern { get; set; }

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

    [ForeignKey("FldPlanId")]
    [InverseProperty("TblRoutePlans")]
    public virtual TblPlan FldPlan { get; set; } = null!;

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblRoutePlans")]
    public virtual TblRoute FldRoute { get; set; } = null!;
}
