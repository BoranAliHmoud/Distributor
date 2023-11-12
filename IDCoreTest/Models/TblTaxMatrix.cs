using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblTaxMatrix")]
public partial class TblTaxMatrix
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldCategory")]
    [StringLength(50)]
    [Unicode(false)]
    public string FldCategory { get; set; } = null!;

    [Column("fldTaxCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string FldTaxCode { get; set; } = null!;

    [Column("fldPlaceOfSupply")]
    [StringLength(50)]
    public string FldPlaceOfSupply { get; set; } = null!;

    [Column("fldJurisdiction")]
    [StringLength(50)]
    public string FldJurisdiction { get; set; } = null!;

    [Column("fldValue")]
    public double FldValue { get; set; }

    [Column("fldVoucherType")]
    [StringLength(50)]
    public string? FldVoucherType { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }
}
