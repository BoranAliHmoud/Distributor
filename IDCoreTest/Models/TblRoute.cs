using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblRoute")]
[Index("FldCode", Name = "IX_tblRouteCode", IsUnique = true)]
public partial class TblRoute
{
    [Key]
    [Column("fldRouteID")]
    public long FldRouteId { get; set; }

    [Column("fldRouteName")]
    [StringLength(150)]
    public string FldRouteName { get; set; } = null!;

    [Column("fldCode")]
    [StringLength(50)]
    public string? FldCode { get; set; }

    [Column("fldVanID")]
    public long? FldVanId { get; set; }

    [Column("fldSalesmanID")]
    public long? FldSalesmanId { get; set; }

    [Column("fldStockID")]
    public long? FldStockId { get; set; }

    [Column("fldPlanId")]
    public long? FldPlanId { get; set; }

    [Column("fldMaxDiscount")]
    public double FldMaxDiscount { get; set; }

    [Column("fldRouteType")]
    public int FldRouteType { get; set; }

    [Column("fldCreditLimit")]
    public double FldCreditLimit { get; set; }

    [Column("fldCurrentBalance")]
    public double FldCurrentBalance { get; set; }

    [Column("fldRouteColor")]
    [StringLength(50)]
    public string? FldRouteColor { get; set; }

    [Column("fldSalesTarget")]
    public double FldSalesTarget { get; set; }

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

    [Column("fldWarehouseId")]
    public long? FldWarehouseId { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldJurisdiction")]
    [StringLength(50)]
    public string? FldJurisdiction { get; set; }

    [Column("fldDriverId")]
    public long? FldDriverId { get; set; }

    [Column("fldHelperId")]
    public long? FldHelperId { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Column("fldCashBalance")]
    public double FldCashBalance { get; set; }

    [Column("fldReturnBalance")]
    public double FldReturnBalance { get; set; }

    [Column("fldCurrencyId")]
    public long? FldCurrencyId { get; set; }

    [Column("fldInitialBalance")]
    public double FldInitialBalance { get; set; }

    [ForeignKey("FldSalesmanId")]
    [InverseProperty("TblRoutes")]
    [JsonIgnore]
    public virtual TblEmployee? FldSalesman { get; set; }

    [ForeignKey("FldStockId")]
    [InverseProperty("TblRoutes")]
    public virtual TblStock? FldStock { get; set; }

    [ForeignKey("FldVanId")]
    [InverseProperty("TblRoutes")]
    public virtual TblVan? FldVan { get; set; }

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblCustomerVisit> TblCustomerVisits { get; set; } = new List<TblCustomerVisit>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblExpense> TblExpenses { get; set; } = new List<TblExpense>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblInvoice> TblInvoices { get; set; } = new List<TblInvoice>();

    [InverseProperty("FldOwnerRoute")]
    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblPayment> TblPayments { get; set; } = new List<TblPayment>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblRequest> TblRequests { get; set; } = new List<TblRequest>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblRoutePlan> TblRoutePlans { get; set; } = new List<TblRoutePlan>();

    [InverseProperty("FldRoute")]
    public virtual ICollection<TblWorkingArea> TblWorkingAreas { get; set; } = new List<TblWorkingArea>();
    [DataMember]
    public String FullNames
    {
        get
        {
            // return FldRouteName + "/Code:"+FldRouteCode+ "/ID:" + FldRouteId + "/VanID:" + FldVanId;
            return FldRouteId + "-" + FldRouteName + "|" + FldCode;
        }
    }

    [DataMember]
    public String SalesmanName
    {
        get
        {
            if (FldSalesman  != null)
                return FldSalesman.FldName + " " + FldSalesman.FldLastName;
            return null;
        }
    }
}
