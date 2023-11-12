using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace IDCoreTest.Models;

[Table("tblProduct")]
[Index("FldCode", Name = "IX_tblProductCode", IsUnique = true)]
public partial class TblProduct
{
    [Key]
    [Column("fldProdID")]
    public long FldProdId { get; set; }

    [Column("fldName")]
    [StringLength(400)]
    public string FldName { get; set; } = null!;

    [Column("fldTranslatedName")]
    [StringLength(400)]
    public string? FldTranslatedName { get; set; }

    [Column("fldCode")]
    [StringLength(50)]
    public string FldCode { get; set; } = null!;

    [Column("fldBarcode")]
    [StringLength(50)]
    public string? FldBarcode { get; set; }

    [Column("fldCategoryID")]
    public long FldCategoryId { get; set; }

    [Column("fldBaseUnit")]
    [StringLength(20)]
    public string FldBaseUnit { get; set; } = null!;

    [Column("fldCostPrice")]
    public double FldCostPrice { get; set; }

    [Column("fldCurrencyId")]
    public long FldCurrencyId { get; set; }

    [Column("fldExchangeRate")]
    public double FldExchangeRate { get; set; }

    [Column("fldCompany")]
    [StringLength(400)]
    public string? FldCompany { get; set; }

    [Column("fldDescription")]
    [StringLength(400)]
    public string? FldDescription { get; set; }

    [Column("fldTax")]
    public double FldTax { get; set; }

    [Column("fldShelfLifeDays")]
    public int? FldShelfLifeDays { get; set; }

    [Column("fldBranchId")]
    public long? FldBranchId { get; set; }

    [Column("fldIsDeleted")]
    public bool FldIsDeleted { get; set; }

    [Column("fldDeleteDate", TypeName = "datetime")]
    public DateTime? FldDeleteDate { get; set; }

    [Column("fldCreateDate", TypeName = "datetime")]
    public DateTime FldCreateDate { get; set; }

    [Required]
    [Column("fldIsActive")]
    public bool? FldIsActive { get; set; }

    [Column("fldLastUpdateDate", TypeName = "datetime")]
    public DateTime? FldLastUpdateDate { get; set; }

    [Column("fldUpdateUserId")]
    public long? FldUpdateUserId { get; set; }

    [Column("fldMinStockAlert")]
    public double? FldMinStockAlert { get; set; }

    [Required]
    [Column("fldIsBatchEnabled")]
    public bool? FldIsBatchEnabled { get; set; }

    [Column("fldTaxCategoryCode")]
    [StringLength(5)]
    [Unicode(false)]
    public string FldTaxCategoryCode { get; set; } = null!;

    [Column("fldTaxCategory")]
    [StringLength(50)]
    public string? FldTaxCategory { get; set; }

    [Column("fldIntegrationReference")]
    [StringLength(50)]
    public string? FldIntegrationReference { get; set; }

    [Column("fldIntegrationPostStatus")]
    public int? FldIntegrationPostStatus { get; set; }

    [Column("fldIntegrationPostDate", TypeName = "datetime")]
    public DateTime? FldIntegrationPostDate { get; set; }

    [Required]
    [Column("fldApplyTax")]
    public bool? FldApplyTax { get; set; }

    [Column("fldApplyFurtherTax")]
    public bool FldApplyFurtherTax { get; set; }

    [Column("fldSubCategoryId")]
    public long? FldSubCategoryId { get; set; }

    [Column("fldTag")]
    [StringLength(512)]
    public string? FldTag { get; set; }

    [Column("fldDisplayOrder")]
    public int FldDisplayOrder { get; set; }

    [Column("fldPlaces")]
    public int FldPlaces { get; set; }

    [Column("fldDisplayUnit")]
    [StringLength(50)]
    public string? FldDisplayUnit { get; set; }

    [Column("fldSalesType")]
    public int FldSalesType { get; set; }

    [ForeignKey("FldCategoryId")]
    [InverseProperty("TblProducts")]
    public virtual TblCategory FldCategory { get; set; } = null!;

    [InverseProperty("FldProduct")]
    public virtual ICollection<TblInvoiceLineItem> TblInvoiceLineItems { get; set; } = new List<TblInvoiceLineItem>();

    [InverseProperty("FldProduct")]
    public virtual ICollection<TblOrderLineItem> TblOrderLineItems { get; set; } = new List<TblOrderLineItem>();

    [InverseProperty("FldProduct")]
    public virtual ICollection<TblPriceBookEntry> TblPriceBookEntries { get; set; } = new List<TblPriceBookEntry>();

    [InverseProperty("FldProduct")]
    public virtual ICollection<TblProductPackage> TblProductPackages { get; set; } = new List<TblProductPackage>();

    [InverseProperty("FldProduct")]
    public virtual ICollection<TblPromotionLineItem> TblPromotionLineItems { get; set; } = new List<TblPromotionLineItem>();

    [InverseProperty("FldProduct")]
    public virtual ICollection<TblPurchaseInvoiceLineItem> TblPurchaseInvoiceLineItems { get; set; } = new List<TblPurchaseInvoiceLineItem>();

    [InverseProperty("Prod")]
    public virtual ICollection<TblStockDailyBalance> TblStockDailyBalances { get; set; } = new List<TblStockDailyBalance>();

    [InverseProperty("FldProd")]
    public virtual ICollection<TblStockTransaction> TblStockTransactions { get; set; } = new List<TblStockTransaction>();

    [DataMember]
    public String FullName
    {
        get
        {
            return FldProdId + "-" + FldName + "|" + FldCode; 
        }
    }

    [DataMember]
    public String NameAndCode
    {
        get
        {
            return FldCode + "|" + FldName; 
        }
    }

}
