using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblTest")]
public partial class TblTest
{
    [Key]
    [Column("fldTestId")]
    public long FldTestId { get; set; }

    [Column("fldCreationDate", TypeName = "datetime")]
    public DateTime FldCreationDate { get; set; }
}
