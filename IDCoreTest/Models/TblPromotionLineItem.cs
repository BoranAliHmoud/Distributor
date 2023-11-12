using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPromotionLineItem")]
public partial class TblPromotionLineItem
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldPromotionID")]
    public long FldPromotionId { get; set; }

    [Column("fldProductID")]
    public long? FldProductId { get; set; }

    [Column("fldQty")]
    public double FldQty { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldProductUnit")]
    [StringLength(50)]
    public string? FldProductUnit { get; set; }

    [Column("fldMaxQty")]
    public double FldMaxQty { get; set; }

    [Column("fldMinQty")]
    public double FldMinQty { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldDiscount")]
    public double FldDiscount { get; set; }

    [Column("fldDiscountType")]
    public int FldDiscountType { get; set; }

    [Column("fldBatchId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldBatchId { get; set; }

    [Column("fldMaxSalesValue")]
    public double? FldMaxSalesValue { get; set; }

    [Column("fldMinSalesValue")]
    public double? FldMinSalesValue { get; set; }

    [ForeignKey("FldProductId")]
    [InverseProperty("TblPromotionLineItems")]
    public virtual TblProduct? FldProduct { get; set; }

    [ForeignKey("FldPromotionId")]
    [InverseProperty("TblPromotionLineItems")]
    public virtual TblPromotionOffer FldPromotion { get; set; } = null!;
}
