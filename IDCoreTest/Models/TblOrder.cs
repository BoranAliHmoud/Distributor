using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblOrder")]
[Index("FldOrderCode", Name = "IX_tblOrder_MobileCode", IsUnique = true)]
public partial class TblOrder
{
    [Key]
    [Column("fldOrderID")]
    public long FldOrderId { get; set; }

    [Column("fldInvoiceID")]
    public long? FldInvoiceId { get; set; }

    [Column("fldOrderCode")]
    [StringLength(50)]
    public string? FldOrderCode { get; set; }

    [Column("fldOrderType")]
    public int? FldOrderType { get; set; }

    [Column("fldOrderStatus")]
    public int FldOrderStatus { get; set; }

    [Column("fldOrderDateTime", TypeName = "datetime")]
    public DateTime? FldOrderDateTime { get; set; }

    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldOwnerRouteID")]
    public long? FldOwnerRouteId { get; set; }

    [Column("fldAssignedRouteID")]
    public long? FldAssignedRouteId { get; set; }

    [Column("fldSalesmanID")]
    public long? FldSalesmanId { get; set; }

    [Column("fldCustomerVisitID")]
    public long FldCustomerVisitId { get; set; }

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

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldComments")]
    [StringLength(255)]
    public string? FldComments { get; set; }

    [Column("fldPlannedDeliveryDate", TypeName = "datetime")]
    public DateTime? FldPlannedDeliveryDate { get; set; }

    [Column("fldDeliveryDate", TypeName = "datetime")]
    public DateTime? FldDeliveryDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateUserID")]
    public long? FldCreateUserId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

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

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCustomerBalance")]
    public double FldCustomerBalance { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldFurtherTaxValue")]
    public double FldFurtherTaxValue { get; set; }

    [Column("fldPackedById")]
    public long? FldPackedById { get; set; }

    [Column("fldPackingDate", TypeName = "datetime")]
    public DateTime? FldPackingDate { get; set; }

    [Column("fldPackingComments")]
    [StringLength(512)]
    public string? FldPackingComments { get; set; }

    [Column("fldPromotionOfferId")]
    public long? FldPromotionOfferId { get; set; }

    [Column("fldPayTermsDesc")]
    [StringLength(255)]
    public string? FldPayTermsDesc { get; set; }

    [Column("fldNotes")]
    [StringLength(512)]
    public string? FldNotes { get; set; }

    [Column("fldCourierName")]
    [StringLength(512)]
    public string? FldCourierName { get; set; }

    [Column("fldCourierNumber")]
    [StringLength(50)]
    public string? FldCourierNumber { get; set; }

    [Column("fldCourierComments")]
    [StringLength(512)]
    public string? FldCourierComments { get; set; }

    [Column("fldDeliveryType")]
    public int FldDeliveryType { get; set; }

    [Column("fldExtraCharges")]
    public double FldExtraCharges { get; set; }

    [Column("fldIntegrationStatusMessage")]
    [StringLength(512)]
    public string? FldIntegrationStatusMessage { get; set; }

    [ForeignKey("FldCustomerId")]
    [InverseProperty("TblOrders")]
    public virtual TblCustomer FldCustomer { get; set; } = null!;

    [ForeignKey("FldOwnerRouteId")]
    [InverseProperty("TblOrders")]
    public virtual TblRoute? FldOwnerRoute { get; set; }

    [InverseProperty("FldOrder")]
    public virtual ICollection<TblOrderLineItem> TblOrderLineItems { get; set; } = new List<TblOrderLineItem>();
}
