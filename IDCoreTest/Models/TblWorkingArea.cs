using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblWorkingArea")]
[Index("FldCode", Name = "IX_tblWorkingArea", IsUnique = true)]
public partial class TblWorkingArea
{
    [Key]
    [Column("fldWorkingAreaID")]
    public long FldWorkingAreaId { get; set; }

    [Column("fldTranslatedName")]
    [StringLength(250)]
    public string? FldTranslatedName { get; set; }

    [Column("fldName")]
    [StringLength(250)]
    public string FldName { get; set; } = null!;

    [Column("fldAdminAreaID")]
    public long FldAdminAreaId { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldCenter_x")]
    public double? FldCenterX { get; set; }

    [Column("fldCenter_y")]
    public double? FldCenterY { get; set; }

    [Column("fldZoomLevel")]
    public double FldZoomLevel { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [ForeignKey("FldAdminAreaId")]
    [InverseProperty("TblWorkingAreas")]
    public virtual TblAdminArea FldAdminArea { get; set; } = null!;

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblWorkingAreas")]
    public virtual TblRoute? FldRoute { get; set; }

    [InverseProperty("FldWorkingArea")]
    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    [DataMember]
    public String FullName
    {
        get
        {
            //if (!string.IsNullOrEmpty(FldEnName) && !string.IsNullOrEmpty(FldArName))
            //    return FldEnName + " - " + FldArName;
            //else
            //    if (!string.IsNullOrEmpty(FldEnName))
            //    return FldEnName;
            //else
            //    return FldArName;
            if (FldAdminArea  != null)
                return FldAdminArea.FullName + " - " + FldName;
            else
                return FldWorkingAreaId + " - " + FldName; //FldAdminAreaId + " - " +
        }
    }
}
