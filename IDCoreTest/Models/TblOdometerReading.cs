using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblOdometerReading")]
public partial class TblOdometerReading
{
    [Key]
    [Column("fldID")]
    public long FldId { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldOdometer")]
    public double FldOdometer { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldLatitude")]
    public double FldLatitude { get; set; }

    [Column("fldLongitude")]
    public double FldLongitude { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }
}
