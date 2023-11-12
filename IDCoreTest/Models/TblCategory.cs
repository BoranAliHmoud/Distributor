using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblCategory")]
[Index("FldCode", "FldType", Name = "IX_tblCategory", IsUnique = true)]
public partial class TblCategory
{
    [Key]
    [Column("fldId")]
    public long FldId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldName")]
    [StringLength(250)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(250)]
    public string? FldTranslatedName { get; set; }

    public bool IsDefault { get; set; }

    [Column("fldParentId")]
    public long? FldParentId { get; set; }

    [Column("fldLevel")]
    public int FldLevel { get; set; }

    [Column("fldDescription")]
    [StringLength(512)]
    public string? FldDescription { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldCoverPhoto")]
    [StringLength(400)]
    public string? FldCoverPhoto { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldDisplayOrder")]
    public int FldDisplayOrder { get; set; }

    [Column("fldCode")]
    [StringLength(100)]
    public string? FldCode { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [InverseProperty("FldCategory")]
    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    [InverseProperty("FldCategory")]
    public virtual ICollection<TblExpense> TblExpenses { get; set; } = new List<TblExpense>();

    [InverseProperty("FldCategory")]
    public virtual ICollection<TblProduct> TblProducts { get; set; } = new List<TblProduct>();

    [InverseProperty("FldCategory")]
    public virtual ICollection<TblRequest> TblRequests { get; set; } = new List<TblRequest>();
}
