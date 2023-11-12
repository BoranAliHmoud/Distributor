using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblRouteProductCategory")]
public partial class TblRouteProductCategory
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldRouteId")]
    public long FldRouteId { get; set; }

    [Column("fldProductId")]
    public long? FldProductId { get; set; }

    [Column("fldCategoryId")]
    public long? FldCategoryId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldCreateUserId")]
    public long? FldCreateUserId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldDisplayOrder")]
    public int FldDisplayOrder { get; set; }
}
