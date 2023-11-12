using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("HtblInvoice")]
public partial class HtblInvoice
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldInvoiceID")]
    public long? FldInvoiceId { get; set; }

    [Column("fldInvoiceType")]
    public int? FldInvoiceType { get; set; }

    [Column("fldInvoiceCollectionStatus")]
    public int? FldInvoiceCollectionStatus { get; set; }

    [Column("fldInvoiceDateTime", TypeName = "datetime")]
    public DateTime? FldInvoiceDateTime { get; set; }

    [Column("fldInvoiceCode")]
    [StringLength(50)]
    public string? FldInvoiceCode { get; set; }

    [Column("fldSalesInvoiceNumber")]
    public long? FldSalesInvoiceNumber { get; set; }

    [Column("fldRefOrderID")]
    public long? FldRefOrderId { get; set; }

    [Column("fldCustomerVisitID")]
    public long FldCustomerVisitId { get; set; }

    [Column("fldRouteID")]
    public long FldRouteId { get; set; }

    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldSalesmanID")]
    public long FldSalesmanId { get; set; }

    [Column("fldTotalSales")]
    public double? FldTotalSales { get; set; }

    [Column("fldDiscount")]
    public double? FldDiscount { get; set; }

    [Column("fldNetTotal")]
    public double? FldNetTotal { get; set; }

    [Column("fldVATValue")]
    public double? FldVatvalue { get; set; }

    [Column("fldGrandTotal")]
    public double? FldGrandTotal { get; set; }

    [Column("fldTotalCollection")]
    public double? FldTotalCollection { get; set; }

    [Column("fldInvoiceCreateDate", TypeName = "datetime")]
    public DateTime? FldInvoiceCreateDate { get; set; }

    [Column("fldComments", TypeName = "text")]
    public string? FldComments { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldPriceBookId")]
    public long? FldPriceBookId { get; set; }

    [Column("fldDeletedBy")]
    public long? FldDeletedBy { get; set; }

    [Column("fldLPONumber")]
    [StringLength(50)]
    public string? FldLponumber { get; set; }

    [Column("fldPlaceOfSupply")]
    [StringLength(50)]
    public string? FldPlaceOfSupply { get; set; }

    [Column("fldJurisdiction")]
    [StringLength(50)]
    public string? FldJurisdiction { get; set; }

    [Column("fldPayTerms")]
    public int FldPayTerms { get; set; }

    [Column("fldDeliveryTerms")]
    public int FldDeliveryTerms { get; set; }

    [Column("fldDriverId")]
    public long? FldDriverId { get; set; }

    [Column("fldHelperId")]
    public long? FldHelperId { get; set; }

    [Column("fldStockId")]
    public long? FldStockId { get; set; }

    [Column("fldReceiverName")]
    [StringLength(100)]
    public string? FldReceiverName { get; set; }

    [Column("fldReceiverMobile")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldReceiverMobile { get; set; }

    [Column("fldDueDate", TypeName = "datetime")]
    public DateTime? FldDueDate { get; set; }

    [Column("fldCustomerBalance")]
    public double FldCustomerBalance { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldSequence")]
    public int? FldSequence { get; set; }
}
