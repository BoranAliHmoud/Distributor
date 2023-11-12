using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblAdminArea")]
public partial class TblAdminArea
{
    [Key]
    [Column("fldAreaID")]
    public long FldAreaId { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldTranslatedName")]
    [StringLength(255)]
    public string? FldTranslatedName { get; set; }

    [Column("fldParentArea_ID")]
    public long? FldParentAreaId { get; set; }

    [Column("fldName")]
    [StringLength(255)]
    public string FldName { get; set; } = null!;

    [Column("fldCenter_x")]
    public double? FldCenterX { get; set; }

    [Column("fldCenter_y")]
    public double? FldCenterY { get; set; }

    [Column("fldZoomLevel")]
    public double FldZoomLevel { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Required]
    [Column("fldIsVisible")]
    public bool? FldIsVisible { get; set; }

    [Column("fldDisplayOrder")]
    public int FldDisplayOrder { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [InverseProperty("FldAdminArea")]
    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    [InverseProperty("FldAdminArea")]
    public virtual ICollection<TblWorkingArea> TblWorkingAreas { get; set; } = new List<TblWorkingArea>();
    [DataMember]
    public String FullName
    {
        get
        {
            if (!string.IsNullOrEmpty(FldName) && !string.IsNullOrEmpty(FldTranslatedName))
                return FldAreaId + "-" + FldName + " (" + FldTranslatedName + ")";
            else  if (!string.IsNullOrEmpty(FldName))
                return FldName;
            else
                return FldTranslatedName;
        }
    }
}
