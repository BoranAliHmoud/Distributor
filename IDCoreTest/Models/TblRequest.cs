using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblRequest")]
public partial class TblRequest
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Column("fldSubject")]
    [StringLength(150)]
    public string? FldSubject { get; set; }

    [Column("fldRequestType")]
    public int FldRequestType { get; set; }

    [Column("fldStatus")]
    public int FldStatus { get; set; }

    [Column("fldCategoryId")]
    public long? FldCategoryId { get; set; }

    [Column("fldEmployeeId")]
    public long? FldEmployeeId { get; set; }

    [Column("fldRouteId")]
    public long? FldRouteId { get; set; }

    [Column("fldCustomerId")]
    public long? FldCustomerId { get; set; }

    [Column("fldDescription")]
    [StringLength(255)]
    public string? FldDescription { get; set; }

    [Column("fldComments")]
    [StringLength(255)]
    public string? FldComments { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldCreateUserId")]
    public long? FldCreateUserId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool? FldIsDeleted { get; set; }

    [Column("fldDeleteDate")]
    [StringLength(10)]
    public string? FldDeleteDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [ForeignKey("FldCategoryId")]
    [InverseProperty("TblRequests")]
    public virtual TblCategory? FldCategory { get; set; }

    [ForeignKey("FldCustomerId")]
    [InverseProperty("TblRequests")]
    public virtual TblCustomer? FldCustomer { get; set; }

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblRequests")]
    public virtual TblRoute? FldRoute { get; set; }
}
