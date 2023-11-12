using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblCustomerVisit")]
public partial class TblCustomerVisit
{
    [Key]
    [Column("fldCustomerVisitID")]
    public long FldCustomerVisitId { get; set; }

    [Column("fldVisitDate", TypeName = "date")]
    public DateTime FldVisitDate { get; set; }

    [Column("fldRouteID")]
    public long FldRouteId { get; set; }

    [Column("fldCustomerID")]
    public long FldCustomerId { get; set; }

    [Column("fldArriveTime", TypeName = "datetime")]
    public DateTime FldArriveTime { get; set; }

    [Column("fldArrivalLatitude")]
    public double? FldArrivalLatitude { get; set; }

    [Column("fldArrivalLongitude")]
    public double? FldArrivalLongitude { get; set; }

    [Column("fldDepartTime", TypeName = "datetime")]
    public DateTime FldDepartTime { get; set; }

    [Column("fldDepartLatitude")]
    public double? FldDepartLatitude { get; set; }

    [Column("fldDepartLongitude")]
    public double? FldDepartLongitude { get; set; }

    [Column("fldNoSalesReasonID")]
    public long? FldNoSalesReasonId { get; set; }

    [Column("fldNotes")]
    [StringLength(512)]
    public string? FldNotes { get; set; }

    [Column("fldVisitType")]
    public int FldVisitType { get; set; }

    [Column("fldDistanceDifference")]
    public double? FldDistanceDifference { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [ForeignKey("FldCustomerId")]
    [InverseProperty("TblCustomerVisits")]
    [JsonIgnore]
    public virtual TblCustomer FldCustomer { get; set; } = null!;

    [ForeignKey("FldNoSalesReasonId")]
    [InverseProperty("TblCustomerVisits")]
    [JsonIgnore]
    public virtual TblNoSalesReason? FldNoSalesReason { get; set; }

    [ForeignKey("FldRouteId")]
    [InverseProperty("TblCustomerVisits")]
    [JsonIgnore]
    public virtual TblRoute FldRoute { get; set; } = null!;

    [InverseProperty("FldCustomerVisit")]
    public virtual ICollection<TblInvoice> TblInvoices { get; set; } = new List<TblInvoice>();

    [InverseProperty("FldCustomerVisit")]
    public virtual ICollection<TblPayment> TblPayments { get; set; } = new List<TblPayment>();
    [DataMember]
    public String RouteName
    {
        get
        {
            if (FldRoute != null)
                return FldRoute.FullNames;
            return null;
        }
    }

    [DataMember]
    public String RouteCode
    {
        get
        {
            if (FldRoute  != null)
                return FldRoute.FldCode;
            return null;
        }
    }
    [DataMember]
    public String CustomerName
    {
        get
        {
            if (FldCustomer != null)
                return FldCustomer.FullName;
            return null;
        }
    }

    [DataMember]
    public double CustomerLatitude
    {
        get
        {
            if (FldCustomer  != null && FldCustomer .FldLatitude.HasValue)
                return FldCustomer .FldLatitude.Value;
            return 0;
        }
    }

    [DataMember]
    public double CustomerLongitude
    {
        get
        {
            if (FldCustomer  != null && FldCustomer .FldLongitude.HasValue)
                return FldCustomer .FldLongitude.Value;
            return 0;
        }
    }

    [DataMember]
    public long CustomerActivityId
    {
        get
        {
            if (FldCustomer  != null)
                return FldCustomer .FldActivityId;
            return 0;
        }
    }
    [DataMember]
    public String NoSalesReason
    {

        get
        {
            //  return FldNoSalesReasonId.ToString();
            if (FldVisitType == -1)
                return "Incomplete";
            if (FldVisitType == 1)
                return "Active";

            //if (FldNoSalesReasonIdSource != null)
            //    return "Inactive";//: " + FldNoSalesReasonIdSource.FldEnDescription;

            return "Inactive";


        }
    }
}
