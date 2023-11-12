using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPurchaseInvoiceLineItem")]
public partial class TblPurchaseInvoiceLineItem
{
    [Key]
    [Column("fldInvoiceLineItemID")]
    public long FldInvoiceLineItemId { get; set; }

    [Column("fldInvoiceID")]
    public long FldInvoiceId { get; set; }

    [Column("fldProductID")]
    public long FldProductId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(20)]
    public string FldProductUnit { get; set; } = null!;

    [Column("fldQty")]
    public double FldQty { get; set; }

    [Column("fldOfferQty")]
    public double FldOfferQty { get; set; }

    [Column("fldReturnQty")]
    public double FldReturnQty { get; set; }

    [Column("fldPrice")]
    public double FldPrice { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldDiscount")]
    public double FldDiscount { get; set; }

    [Column("fldTaxValue")]
    public double FldTaxValue { get; set; }

    [Column("fldValue")]
    public double FldValue { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

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

    [ForeignKey("FldInvoiceId")]
    [InverseProperty("TblPurchaseInvoiceLineItems")]
    public virtual TblPurchaseInvoice FldInvoice { get; set; } = null!;

    [ForeignKey("FldProductId")]
    [InverseProperty("TblPurchaseInvoiceLineItems")]
    public virtual TblProduct FldProduct { get; set; } = null!;
}
