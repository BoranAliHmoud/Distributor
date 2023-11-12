using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblProductPackage")]
[Index("FldProductId", "FldProductUnit", Name = "IX_tblProductPackage", IsUnique = true)]
public partial class TblProductPackage
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldProductId")]
    public long FldProductId { get; set; }

    [Column("fldProductUnit")]
    [StringLength(20)]
    public string FldProductUnit { get; set; } = null!;

    [Column("fldBarcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FldBarcode { get; set; }

    [Column("fldCostPrice")]
    public double FldCostPrice { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldConversionQty")]
    public double FldConversionQty { get; set; }

    [Column("fldUnitVolume")]
    public double? FldUnitVolume { get; set; }

    [Column("fldUnitWeight")]
    public double? FldUnitWeight { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldMinStockAlert")]
    public double? FldMinStockAlert { get; set; }

    [Column("fldProductCode")]
    [StringLength(50)]
    public string? FldProductCode { get; set; }

    [Column("fldProductUnitCode")]
    [StringLength(50)]
    public string? FldProductUnitCode { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldPlaces")]
    public int FldPlaces { get; set; }

    [ForeignKey("FldProductId")]
    [InverseProperty("TblProductPackages")]
    public virtual TblProduct FldProduct { get; set; } = null!;
}
