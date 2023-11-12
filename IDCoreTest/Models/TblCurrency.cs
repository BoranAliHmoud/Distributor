using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblCurrency")]
[Index("FldSymbol", Name = "IX_tblCurrency", IsUnique = true)]
public partial class TblCurrency
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldSymbol")]
    [StringLength(10)]
    public string FldSymbol { get; set; } = null!;

    [Column("fldName")]
    [StringLength(50)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(50)]
    public string? FldTranslatedName { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldIsMainCurrency")]
    public bool FldIsMainCurrency { get; set; }

    [Column("fldPlaces")]
    public int FldPlaces { get; set; }

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

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [InverseProperty("FldCurrency")]
    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    [InverseProperty("FldCurrency")]
    public virtual ICollection<TblPriceBookEntry> TblPriceBookEntries { get; set; } = new List<TblPriceBookEntry>();
}
