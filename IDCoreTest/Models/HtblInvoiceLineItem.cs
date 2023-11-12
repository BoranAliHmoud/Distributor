using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("HtblInvoiceLineItem")]
public partial class HtblInvoiceLineItem
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldlnvoiceLineItemID")]
    public long? FldlnvoiceLineItemId { get; set; }

    [Column("fldInvoiceID")]
    public long FldInvoiceId { get; set; }

    [Column("fldProductID")]
    public long FldProductId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(50)]
    public string? FldProductUnit { get; set; }

    [Column("fldQty")]
    public double? FldQty { get; set; }

    [Column("fldOfferQty")]
    public double? FldOfferQty { get; set; }

    [Column("fldPrice")]
    public double FldPrice { get; set; }

    [Column("fldDiscount")]
    public double? FldDiscount { get; set; }

    [Column("fldValue")]
    public double? FldValue { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldReturnQty")]
    public double? FldReturnQty { get; set; }

    [Column("fldItemCreateDate", TypeName = "datetime")]
    public DateTime? FldItemCreateDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldBatchId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldBatchId { get; set; }

    [Column("fldSerialNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldSerialNumber { get; set; }

    [Column("fldProductionDate", TypeName = "datetime")]
    public DateTime? FldProductionDate { get; set; }

    [Column("fldExpiryDate", TypeName = "datetime")]
    public DateTime? FldExpiryDate { get; set; }

    [Column("fldTaxCategoryCode")]
    [StringLength(5)]
    [Unicode(false)]
    public string FldTaxCategoryCode { get; set; } = null!;
}
