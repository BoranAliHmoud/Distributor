using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPayment")]
[Index("FldPaymentCode", Name = "IX_tblPayment_mobile_code", IsUnique = true)]
public partial class TblPayment
{
    [Key]
    [Column("fldPaymentID")]
    public long FldPaymentId { get; set; }

    [Column("fldPaymentCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldPaymentCode { get; set; }

    [Column("fldInvoiceCode")]
    [StringLength(50)]
    public string? FldInvoiceCode { get; set; }

    [Column("fldRefInvoiceId")]
    public long? FldRefInvoiceId { get; set; }

    [Column("fldAmount")]
    public double FldAmount { get; set; }

    [Column("fldPaymentDate", TypeName = "datetime")]
    public DateTime FldPaymentDate { get; set; }

    [Column("fldPaymentType")]
    public int FldPaymentType { get; set; }

    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldCustomerVisitID")]
    public long? FldCustomerVisitId { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldSalesmanID")]
    public long? FldSalesmanId { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldNotes")]
    [StringLength(300)]
    public string? FldNotes { get; set; }

    [Column("fldChequeNo")]
    [StringLength(10)]
    public string? FldChequeNo { get; set; }

    [Column("fldChequeDate", TypeName = "date")]
    public DateTime? FldChequeDate { get; set; }

    [Column("fldChequePhotoUrl")]
    [StringLength(1000)]
    public string? FldChequePhotoUrl { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldCollectionStatus")]
    public int FldCollectionStatus { get; set; }

    [Column("fldCollectionDate", TypeName = "datetime")]
    public DateTime? FldCollectionDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCustomerBalance")]
    public double FldCustomerBalance { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldRemmitanceBankAccount")]
    [StringLength(50)]
    public string? FldRemmitanceBankAccount { get; set; }

    [Column("fldReceiptMethod")]
    [StringLength(50)]
    public string? FldReceiptMethod { get; set; }

    [Column("fldCreateUserID")]
    public long? FldCreateUserId { get; set; }

    [Column("fldIntegrationStatusMessage")]
    [StringLength(512)]
    public string? FldIntegrationStatusMessage { get; set; }

    [Column("fldDiscount")]
    public double? FldDiscount { get; set; }

    [ForeignKey("FldCustomerId")]
    [InverseProperty("TblPayments")]
    public virtual TblCustomer FldCustomer { get; set; } = null!;

    [ForeignKey("FldCustomerVisitId")]
    [InverseProperty("TblPayments")]
    public virtual TblCustomerVisit? FldCustomerVisit { get; set; }

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblPayments")]
    public virtual TblRoute? FldRoute { get; set; }
}
