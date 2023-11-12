using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblInvoice")]
[Index("FldInvoiceCode", Name = "IX_tblInvoice_mobile_code", IsUnique = true)]
public partial class TblInvoice
{
    [Key]
    [Column("fldInvoiceID")]
    public long FldInvoiceId { get; set; }

    [Column("fldInvoiceType")]
    public int FldInvoiceType { get; set; }

    [Column("fldInvoiceCollectionStatus")]
    public int FldInvoiceCollectionStatus { get; set; }

    [Column("fldInvoiceDateTime", TypeName = "datetime")]
    public DateTime FldInvoiceDateTime { get; set; }

    [Column("fldInvoiceCode")]
    [StringLength(50)]
    public string? FldInvoiceCode { get; set; }

    [Column("fldSalesInvoiceNumber")]
    public long? FldSalesInvoiceNumber { get; set; }

    [Column("fldRefOrderID")]
    public long? FldRefOrderId { get; set; }

    [Column("fldRouteID")]
    public long FldRouteId { get; set; }

    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldSalesmanID")]
    public long FldSalesmanId { get; set; }

    [Column("fldCustomerVisitID")]
    public long FldCustomerVisitId { get; set; }

    [Column("fldPriceBookId")]
    public long FldPriceBookId { get; set; }

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

    [Column("fldComments")]
    [StringLength(512)]
    public string? FldComments { get; set; }

    [Column("fldCreateUserId")]
    public long? FldCreateUserId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldLastUpdateUserId")]
    public long? FldLastUpdateUserId { get; set; }

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
    [StringLength(50)]
    public string? FldPayTerms { get; set; }

    [Column("fldDeliveryTerms")]
    [StringLength(50)]
    public string? FldDeliveryTerms { get; set; }

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

    [Column("fldCustomerBalance")]
    public double FldCustomerBalance { get; set; }

    [Column("fldDueDate", TypeName = "datetime")]
    public DateTime? FldDueDate { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldSequence")]
    public int? FldSequence { get; set; }

    [Column("fldUUID")]
    [StringLength(128)]
    public string? FldUuid { get; set; }

    [Column("fldHash")]
    [StringLength(255)]
    public string? FldHash { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldIntegrationOrderReference")]
    [StringLength(50)]
    public string? FldIntegrationOrderReference { get; set; }

    [Column("fldFurtherTaxValue")]
    public double FldFurtherTaxValue { get; set; }

    [Column("fldPromotionOfferId")]
    public long? FldPromotionOfferId { get; set; }

    [Column("fldExtraCharges")]
    public double FldExtraCharges { get; set; }

    [Column("fldGroupPaymentReference")]
    [StringLength(50)]
    public string? FldGroupPaymentReference { get; set; }

    [Column("fldFlag")]
    public int FldFlag { get; set; }

    [Column("fldIntegrationStatusMessage")]
    [StringLength(512)]
    public string? FldIntegrationStatusMessage { get; set; }

    [ForeignKey("FldCustomerId")]
    [InverseProperty("TblInvoices")]
    public virtual TblCustomer FldCustomer { get; set; } = null!;

    [ForeignKey("FldCustomerVisitId")]
    [InverseProperty("TblInvoices")]
    public virtual TblCustomerVisit FldCustomerVisit { get; set; } = null!;

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblInvoices")]
    public virtual TblRoute FldRoute { get; set; } = null!;

    [InverseProperty("FldInvoice")]
    public virtual ICollection<TblInvoiceLineItem> TblInvoiceLineItems { get; set; } = new List<TblInvoiceLineItem>();
}
