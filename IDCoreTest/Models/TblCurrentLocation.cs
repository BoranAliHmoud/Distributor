using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblCurrentLocation")]
public partial class TblCurrentLocation
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldLat")]
    public double FldLat { get; set; }

    [Column("fldLon")]
    public double FldLon { get; set; }

    [Column("fldTime", TypeName = "datetime")]
    public DateTime FldTime { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }
}
