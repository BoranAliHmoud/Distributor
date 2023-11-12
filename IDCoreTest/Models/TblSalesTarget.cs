using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblSalesTarget")]
public partial class TblSalesTarget
{
    [Key]
    [Column("fldSalesTargetID")]
    public long FldSalesTargetId { get; set; }

    [Column("fldProductID")]
    public long? FldProductId { get; set; }

    [Column("fldCustomerID")]
    public long? FldCustomerId { get; set; }

    [Column("fldRouteID")]
    public long? FldRouteId { get; set; }

    [Column("fldSalesmanID")]
    public long? FldSalesmanId { get; set; }

    [Column("fldAmount")]
    public double FldAmount { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldType")]
    public int FldType { get; set; }

    [Column("fldDescription", TypeName = "text")]
    public string? FldDescription { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldStartDate", TypeName = "date")]
    public DateTime FldStartDate { get; set; }

    [Column("fldEndDate", TypeName = "date")]
    public DateTime? FldEndDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }
}
