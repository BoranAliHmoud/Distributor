using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblInvoiceLineItem")]
public partial class TblInvoiceLineItem
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

    [Column("fldDiscount")]
    public double FldDiscount { get; set; }

    [Column("fldTaxValue")]
    public double FldTaxValue { get; set; }

    [Column("fldValue")]
    public double FldValue { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldNote")]
    [StringLength(200)]
    public string? FldNote { get; set; }

    [Column("fldIsDamaged")]
    public bool FldIsDamaged { get; set; }

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

    [Column("fldFurtherTaxValue")]
    public double FldFurtherTaxValue { get; set; }

    [ForeignKey("FldInvoiceId")]
    [InverseProperty("TblInvoiceLineItems")]
    public virtual TblInvoice FldInvoice { get; set; } = null!;

    [ForeignKey("FldProductId")]
    [InverseProperty("TblInvoiceLineItems")]
    [JsonIgnore]
    public virtual TblProduct FldProduct { get; set; } = null!;

    [DataMember]
    public System.String ProductName
    {
        get
        {
            if (FldProduct  != null)
                return FldProduct .FldName;
            return null;
        }
    }
}
