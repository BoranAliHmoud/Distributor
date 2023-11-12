using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblAppPhoto")]
public partial class TblAppPhoto
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldName")]
    [StringLength(150)]
    public string FldName { get; set; } = null!;

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldProductId")]
    public long? FldProductId { get; set; }

    [Column("fldCustomerId")]
    public long? FldCustomerId { get; set; }

    [Column("fldComments")]
    [StringLength(255)]
    public string? FldComments { get; set; }

    [Column("fldPhotoUrl")]
    [StringLength(400)]
    public string FldPhotoUrl { get; set; } = null!;

    [Column("fldLatitude")]
    public double? FldLatitude { get; set; }

    [Column("fldLongitude")]
    public double? FldLongitude { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldInvoiceId")]
    public long? FldInvoiceId { get; set; }

    [Column("fldPaymentId")]
    public long? FldPaymentId { get; set; }

    [Column("fldVisitId")]
    public long? FldVisitId { get; set; }

    [Column("fldExpenseId")]
    public long? FldExpenseId { get; set; }

    [Column("fldCategoryId")]
    public long? FldCategoryId { get; set; }

    [Column("fldPromotionOfferId")]
    public long? FldPromotionOfferId { get; set; }

    [Column("fldVanId")]
    public long? FldVanId { get; set; }

    [Column("fldEmployeeId")]
    public long? FldEmployeeId { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldOrderId")]
    public long? FldOrderId { get; set; }

    [Column("fldAssetId")]
    public long? FldAssetId { get; set; }

    [Column("fldFileType")]
    public int FldFileType { get; set; }
}
