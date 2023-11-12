using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblStock")]
[Index("FldCode", Name = "IX_tblStock", IsUnique = true)]
public partial class TblStock
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(255)]
    public string? FldName { get; set; }

    [Column("fldTranslatedName")]
    [StringLength(255)]
    public string? FldTranslatedName { get; set; }

    /// <summary>
    /// 1 warehouse - 2 route stock
    /// </summary>
    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldDescription")]
    [StringLength(255)]
    public string? FldDescription { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCode")]
    [StringLength(100)]
    public string? FldCode { get; set; }

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [InverseProperty("FldStock")]
    public virtual ICollection<TblRoute> TblRoutes { get; set; } = new List<TblRoute>();

    [InverseProperty("Stock")]
    public virtual ICollection<TblStockDailyBalance> TblStockDailyBalances { get; set; } = new List<TblStockDailyBalance>();
}
