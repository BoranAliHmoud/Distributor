using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblExpense")]
public partial class TblExpense
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldCategoryId")]
    public long FldCategoryId { get; set; }

    [Column("fldAmount")]
    public double FldAmount { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExpenseDate", TypeName = "datetime")]
    public DateTime FldExpenseDate { get; set; }

    [Column("fldDescription")]
    [StringLength(512)]
    public string? FldDescription { get; set; }

    [Column("fldComments")]
    [StringLength(512)]
    public string? FldComments { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldReceiptPhoto")]
    [StringLength(400)]
    public string? FldReceiptPhoto { get; set; }

    [Column("fldPurchaseInvoiceId")]
    public long? FldPurchaseInvoiceId { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [ForeignKey("FldCategoryId")]
    [InverseProperty("TblExpenses")]
    public virtual TblCategory FldCategory { get; set; } = null!;

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblExpenses")]
    public virtual TblRoute? FldRoute { get; set; }
}
