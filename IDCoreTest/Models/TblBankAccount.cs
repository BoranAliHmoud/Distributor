using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblBankAccount")]
public partial class TblBankAccount
{
    [Key]
    [Column("fldId")]
    public int FldId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldAccountName")]
    [StringLength(255)]
    public string FldAccountName { get; set; } = null!;

    [Column("fldAccountNumber")]
    [StringLength(50)]
    public string FldAccountNumber { get; set; } = null!;

    [Column("fldReceiptMethod")]
    [StringLength(50)]
    public string? FldReceiptMethod { get; set; }

    [Column("fldBankName")]
    [StringLength(512)]
    public string? FldBankName { get; set; }

    [Column("fldBankAddress")]
    [StringLength(512)]
    public string? FldBankAddress { get; set; }

    [Column("fldIBAN")]
    [StringLength(50)]
    public string? FldIban { get; set; }

    [Column("fldType")]
    public int? FldType { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }
}
