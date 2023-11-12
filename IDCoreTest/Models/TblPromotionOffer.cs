using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPromotionOffer")]
public partial class TblPromotionOffer
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(255)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(255)]
    public string? FldTranslatedName { get; set; }

    [Column("fldDescription")]
    [StringLength(255)]
    public string? FldDescription { get; set; }

    [Column("fldDiscount")]
    public double FldDiscount { get; set; }

    [Column("fldStartDate", TypeName = "datetime")]
    public DateTime FldStartDate { get; set; }

    [Column("fldEndDate", TypeName = "datetime")]
    public DateTime? FldEndDate { get; set; }

    [Column("fldStatus")]
    public int FldStatus { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldMaxQuantity")]
    public double? FldMaxQuantity { get; set; }

    [Column("fldMaxValue")]
    public double FldMaxValue { get; set; }

    [Column("fldMinValue")]
    public double FldMinValue { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldPriceBookId")]
    public long? FldPriceBookId { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldDiscountType")]
    public int FldDiscountType { get; set; }

    [Column("fldCustomerId")]
    [StringLength(100)]
    public string? FldCustomerId { get; set; }

    [Column("fldProductId")]
    public long? FldProductId { get; set; }

    [Column("fldWorkingAreaId")]
    public long? FldWorkingAreaId { get; set; }

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldCategoryId")]
    public long? FldCategoryId { get; set; }

    [Column("fldAvailableQuantity")]
    public double FldAvailableQuantity { get; set; }

    [Column("fldMaxSalesQty")]
    public double? FldMaxSalesQty { get; set; }

    [Column("fldMinSalesQty")]
    public double? FldMinSalesQty { get; set; }

    [Column("fldPriority")]
    public int FldPriority { get; set; }

    [InverseProperty("FldPromotion")]
    public virtual ICollection<TblPromotionLineItem> TblPromotionLineItems { get; set; } = new List<TblPromotionLineItem>();
}
