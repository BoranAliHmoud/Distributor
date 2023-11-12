using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("HtblStockDailyBalance")]
public partial class HtblStockDailyBalance
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldOrginialId")]
    public long FldOrginialId { get; set; }

    [Column("fldStockID")]
    public long FldStockId { get; set; }

    [Column("fldProductID")]
    public long FldProductId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(20)]
    public string FldProductUnit { get; set; } = null!;

    [Column("fldBatchId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldBatchId { get; set; }

    [Column("fldExpiryDate", TypeName = "datetime")]
    public DateTime? FldExpiryDate { get; set; }

    [Column("fldProductionDate", TypeName = "datetime")]
    public DateTime? FldProductionDate { get; set; }

    [Column("fldSerialNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldSerialNumber { get; set; }

    [Column("fldInitialBalance")]
    public double FldInitialBalance { get; set; }

    [Column("fldLoadBalance")]
    public double FldLoadBalance { get; set; }

    [Column("fldStartBalance")]
    public double FldStartBalance { get; set; }

    [Column("fldDamageBalance")]
    public double FldDamageBalance { get; set; }

    [Column("fldResellBalance")]
    public double FldResellBalance { get; set; }

    [Column("fldTransferInBalance")]
    public double FldTransferInBalance { get; set; }

    [Column("fldTransferOutBalance")]
    public double FldTransferOutBalance { get; set; }

    [Column("fldSalesBalance")]
    public double FldSalesBalance { get; set; }

    [Column("fldAdjust")]
    public double FldAdjust { get; set; }

    [Column("fldDate", TypeName = "date")]
    public DateTime FldDate { get; set; }

    [Column("fldOfferBalance")]
    public double FldOfferBalance { get; set; }

    [Column("fldCloseBalance")]
    public double FldCloseBalance { get; set; }

    [Column("fldUnPack")]
    public double FldUnPack { get; set; }

    [Column("fldLoadUnPack")]
    public double FldLoadUnPack { get; set; }

    [Column("fldUnLoad")]
    public double FldUnLoad { get; set; }

    [Column("fldOriginalCreateDate", TypeName = "datetime")]
    public DateTime FldOriginalCreateDate { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }
}
