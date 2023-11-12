using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblStockDailyBalance")]
[Index("ProdId", "Date", "StockId", "FldBatchId", Name = "IX_tblStockDailyBalance", IsUnique = true)]
public partial class TblStockDailyBalance
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("StockID")]
    public long StockId { get; set; }

    [Column("ProdID")]
    public long ProdId { get; set; }

    [StringLength(20)]
    public string ProductUnit { get; set; } = null!;

    public double InitialBalance { get; set; }

    public double LoadBalance { get; set; }

    public double StartBalance { get; set; }

    public double DamageBalance { get; set; }

    public double ResellBalance { get; set; }

    public double TransferInBalance { get; set; }

    public double TransferOutBalance { get; set; }

    public double SalesBalance { get; set; }

    [Column("adjust")]
    public double Adjust { get; set; }

    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    public double OfferBalance { get; set; }

    public double CloseBalance { get; set; }

    public double UnPack { get; set; }

    public double LoadUnPack { get; set; }

    public double UnLoad { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldBatchId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldBatchId { get; set; }

    [Column("fldExpiryDate", TypeName = "datetime")]
    public DateTime? FldExpiryDate { get; set; }

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

    [ForeignKey("ProdId")]
    [InverseProperty("TblStockDailyBalances")]
    public virtual TblProduct Prod { get; set; } = null!;

    [ForeignKey("StockId")]
    [InverseProperty("TblStockDailyBalances")]
    public virtual TblStock Stock { get; set; } = null!;
}
