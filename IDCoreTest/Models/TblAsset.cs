using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblAsset")]
public partial class TblAsset
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(200)]
    public string FldName { get; set; } = null!;

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCustomerId")]
    public long? FldCustomerId { get; set; }

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldCategoryId")]
    public long? FldCategoryId { get; set; }

    [Column("fldType")]
    public int? FldType { get; set; }

    [Column("fldInstallationDate", TypeName = "datetime")]
    public DateTime? FldInstallationDate { get; set; }

    [Column("fldStatus")]
    public int FldStatus { get; set; }

    [Column("fldCost")]
    public double FldCost { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldLatitude")]
    public double? FldLatitude { get; set; }

    [Column("fldLongitude")]
    public double? FldLongitude { get; set; }

    [Column("fldDescription")]
    [StringLength(512)]
    [Unicode(false)]
    public string? FldDescription { get; set; }

    [Column("fldComments")]
    [StringLength(512)]
    public string? FldComments { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastInspectionDate", TypeName = "datetime")]
    public DateTime? FldLastInspectionDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }
}
