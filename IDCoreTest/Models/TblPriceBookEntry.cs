using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblPriceBookEntry")]
[Index("FldCurrencyId", "FldPriceBookId", "FldProductId", "FldProductUnit", "FldTier", "FldIsDeleted", Name = "IX_tblPriceBookEntry", IsUnique = true)]
public partial class TblPriceBookEntry
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldPriceBookId")]
    public long FldPriceBookId { get; set; }

    [Column("fldProductId")]
    public long FldProductId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(20)]
    public string FldProductUnit { get; set; } = null!;

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldPrice")]
    public double FldPrice { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldMinQuantity")]
    public double FldMinQuantity { get; set; }

    [Column("fldMaxQuantity")]
    public double FldMaxQuantity { get; set; }

    [Column("fldPricingModel")]
    public int FldPricingModel { get; set; }

    [Column("fldFlatFee")]
    public double FldFlatFee { get; set; }

    [Column("fldTier")]
    public int? FldTier { get; set; }

    [Column("fldDescription")]
    [StringLength(255)]
    public string? FldDescription { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldDiscount")]
    public double FldDiscount { get; set; }

    [ForeignKey("FldCurrencyId")]
    [InverseProperty("TblPriceBookEntries")]
    public virtual TblCurrency FldCurrency { get; set; } = null!;

    [ForeignKey("FldPriceBookId")]
    [InverseProperty("TblPriceBookEntries")]
    public virtual TblPriceBook FldPriceBook { get; set; } = null!;

    [ForeignKey("FldProductId")]
    [InverseProperty("TblPriceBookEntries")]
    public virtual TblProduct FldProduct { get; set; } = null!;
}
