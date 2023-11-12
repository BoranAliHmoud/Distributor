using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPurchaseInvoice")]
public partial class TblPurchaseInvoice
{
    [Key]
    [Column("fldInvoiceID")]
    public long FldInvoiceId { get; set; }

    [Column("fldInvoiceStatus")]
    public int FldInvoiceStatus { get; set; }

    [Column("fldInvoiceDateTime", TypeName = "datetime")]
    public DateTime FldInvoiceDateTime { get; set; }

    [Column("fldInvoiceCode")]
    [StringLength(50)]
    public string? FldInvoiceCode { get; set; }

    [Column("fldVendorID")]
    public long FldVendorId { get; set; }

    [Column("fldTotalSales")]
    public double FldTotalSales { get; set; }

    [Column("fldDiscount")]
    public double FldDiscount { get; set; }

    [Column("fldNetTotal")]
    public double FldNetTotal { get; set; }

    [Column("fldVATValue")]
    public double FldVatvalue { get; set; }

    [Column("fldGrandTotal")]
    public double FldGrandTotal { get; set; }

    [Column("fldTotalCollection")]
    public double FldTotalCollection { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldWarehouseId")]
    public long? FldWarehouseId { get; set; }

    [Column("fldComments")]
    [StringLength(512)]
    public string? FldComments { get; set; }

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

    [Column("fldPaidAmount")]
    public double FldPaidAmount { get; set; }

    [Column("fldPayStatus")]
    public int FldPayStatus { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [ForeignKey("FldVendorId")]
    [InverseProperty("TblPurchaseInvoices")]
    public virtual TblCompanyInfo FldVendor { get; set; } = null!;

    [InverseProperty("FldInvoice")]
    public virtual ICollection<TblPurchaseInvoiceLineItem> TblPurchaseInvoiceLineItems { get; set; } = new List<TblPurchaseInvoiceLineItem>();
}
