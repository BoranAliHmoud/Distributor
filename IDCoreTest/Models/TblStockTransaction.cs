using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblStockTransactions")]
public partial class TblStockTransaction
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldSourceID")]
    public long? FldSourceId { get; set; }

    [Column("fldDestinationID")]
    public long? FldDestinationId { get; set; }

    [Column("fldTransactionDate", TypeName = "datetime")]
    public DateTime FldTransactionDate { get; set; }

    [Column("fldInvoiceID")]
    public long? FldInvoiceId { get; set; }

    [Column("fldProdID")]
    public long? FldProdId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(20)]
    public string? FldProductUnit { get; set; }

    [Column("fldQty")]
    public double FldQty { get; set; }

    [Column("fldlnvoiceLineItemID")]
    public long? FldlnvoiceLineItemId { get; set; }

    [Column("fldBeforeQty")]
    public double? FldBeforeQty { get; set; }

    [Column("fldType")]
    [StringLength(100)]
    public string? FldType { get; set; }

    public bool? IsSourceCustomer { get; set; }

    public bool? IsDestinationCustomer { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime? FldCreateDate { get; set; }

    [Column("fldTransactionType")]
    public int FldTransactionType { get; set; }

    [Column("fldComments")]
    [StringLength(400)]
    public string? FldComments { get; set; }

    [Column("fldUserId")]
    public long? FldUserId { get; set; }

    [Column("fldUsername")]
    [StringLength(50)]
    public string? FldUsername { get; set; }

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

    [ForeignKey("FldProdId")]
    [InverseProperty("TblStockTransactions")]
    public virtual TblProduct? FldProd { get; set; }
}
