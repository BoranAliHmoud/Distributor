using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblSession")]
public partial class TblSession
{
    [Key]
    [Column("fldSessionID")]
    public long FldSessionId { get; set; }

    [Column("fldSessionDate", TypeName = "date")]
    public DateTime FldSessionDate { get; set; }

    [Column("fldUserID")]
    public long? FldUserId { get; set; }

    [Column("fldUserName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FldUserName { get; set; }

    [Column("fldStartTime", TypeName = "datetime")]
    public DateTime FldStartTime { get; set; }

    [Column("fldEndTime", TypeName = "datetime")]
    public DateTime? FldEndTime { get; set; }

    [Column("fldStatus")]
    public short? FldStatus { get; set; }

    [Column("fldClientIP")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FldClientIp { get; set; }

    [Column("fldClientBrowser")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FldClientBrowser { get; set; }

    [Column("fldComments")]
    [StringLength(512)]
    public string? FldComments { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCreateUserId")]
    public long? FldCreateUserId { get; set; }

    [Column("fldTrrUserId")]
    public long? FldTrrUserId { get; set; }
}
