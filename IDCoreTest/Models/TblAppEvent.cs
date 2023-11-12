using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblAppEvent")]
public partial class TblAppEvent
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldUserId")]
    public long FldUserId { get; set; }

    [Column("fldRouteId")]
    public long FldRouteId { get; set; }

    [Column("fldSalesmanId")]
    public long FldSalesmanId { get; set; }

    [Column("fldInvoiceId")]
    public long? FldInvoiceId { get; set; }

    [Column("fldPaymentId")]
    public long? FldPaymentId { get; set; }

    [Column("fldCustomerId")]
    public long? FldCustomerId { get; set; }

    [Column("fldEventTime", TypeName = "datetime")]
    public DateTime FldEventTime { get; set; }

    [Column("fldEventType")]
    public int FldEventType { get; set; }

    [Column("fldLatitude")]
    public double? FldLatitude { get; set; }

    [Column("fldLongitude")]
    public double? FldLongitude { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldEventEndTime", TypeName = "datetime")]
    public DateTime? FldEventEndTime { get; set; }

    [Column("fldComments")]
    [StringLength(512)]
    public string? FldComments { get; set; }
}
