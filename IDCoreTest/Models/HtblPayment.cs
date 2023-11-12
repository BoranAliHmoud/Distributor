using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("HtblPayment")]
public partial class HtblPayment
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldPaymentID")]
    public long? FldPaymentId { get; set; }

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
    public double? FldAmount { get; set; }

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
    public long? FldCurrencyId { get; set; }

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

    [Column("fldPaymentCreateDate", TypeName = "date")]
    public DateTime? FldPaymentCreateDate { get; set; }

    [Column("fldComments", TypeName = "text")]
    public string? FldComments { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldCollectionStatus")]
    public int? FldCollectionStatus { get; set; }

    [Column("fldCollectionDate", TypeName = "datetime")]
    public DateTime? FldCollectionDate { get; set; }
}
