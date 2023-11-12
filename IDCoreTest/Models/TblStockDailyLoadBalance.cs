using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblStockDailyLoadBalance")]
public partial class TblStockDailyLoadBalance
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldStockID")]
    public long FldStockId { get; set; }

    [Column("fldProdID")]
    public long FldProdId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(20)]
    public string FldProductUnit { get; set; } = null!;

    [Column("fldLoadQty")]
    public double FldLoadQty { get; set; }

    [Column("fldActualLoadQty")]
    public double FldActualLoadQty { get; set; }

    [Column("fldIsApplied")]
    public bool FldIsApplied { get; set; }

    [Column("fldDate", TypeName = "datetime")]
    public DateTime FldDate { get; set; }

    [Column("fldAppliedDate", TypeName = "datetime")]
    public DateTime? FldAppliedDate { get; set; }

    [Column("fldBatchId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldBatchId { get; set; }

    [Column("fldExpiryDate", TypeName = "datetime")]
    public DateTime? FldExpiryDate { get; set; }

    [Column("fldWarehouseId")]
    public long? FldWarehouseId { get; set; }

    [Column("fldOrderId")]
    public long? FldOrderId { get; set; }

    [Column("fldComments")]
    [StringLength(255)]
    public string? FldComments { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldSerialNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldSerialNumber { get; set; }

    [Column("fldProductionDate", TypeName = "datetime")]
    public DateTime? FldProductionDate { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldRequestNumber")]
    [StringLength(50)]
    public string? FldRequestNumber { get; set; }

    [Column("fldIntegrationStatusMessage")]
    [StringLength(512)]
    public string? FldIntegrationStatusMessage { get; set; }
}
