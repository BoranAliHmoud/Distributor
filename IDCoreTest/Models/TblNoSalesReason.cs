using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblNoSalesReason")]
public partial class TblNoSalesReason
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldName")]
    [StringLength(400)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(250)]
    public string? FldTranslatedName { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldDescription")]
    [StringLength(200)]
    public string? FldDescription { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldDisplayOrder")]
    public int FldDisplayOrder { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [InverseProperty("FldNoSalesReason")]
    public virtual ICollection<TblCustomerVisit> TblCustomerVisits { get; set; } = new List<TblCustomerVisit>();
}
