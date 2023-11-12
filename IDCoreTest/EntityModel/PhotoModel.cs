using IDCoreTest.Models;

namespace IDCoreTest
{
    public class PhotoModel : EntityModel
    {
        public long Id;
        public long ObjectId;
        public long? AssetId;
        public long? CategoryId;
        public long? ProductId;
        public long? RouteId;
        public long? CustomerId;
        public long? InvoiceId;
        public long? OrderId;
        public long? PaymentId;
        public long? VisitId;
        public long? ExpenseId;
        public long? VanId;
        public long? EmployeeId;
        public long? PromotionOfferId;

        public string Name;
        public string Url;
        public double? Longitude;
        public double? Latitude;
        public string Comments;

        public string Description;
        public string PhotoData;

        public DateTime CreateDateTime;
        public int Type = (int)AppPhotoType.ProductPhoto;

        public PhotoModel() { }
        public PhotoModel(string name, string url, string desc, DateTime createDate)
        {
            Name = name;
            Url = url;
            Description = desc;
            CreateDateTime = createDate;
        }
        public PhotoModel(TblAppPhoto photo)
        {
            Name = photo.FldName;
            //Url = photo.FldPhotoUrl;
            //Ehab 16122022 updated to construct full url as no need to save full url (with baseUrl) in database as baseUrl can change
            Url = new Uri(Common.PhotosURI, photo.FldPhotoUrl).AbsoluteUri; //Common.PhotosURI + photo.FldPhotoUrl;
            Comments = photo.FldComments;
            Description = photo.FldComments;
            CreateDateTime = photo.FldCreateDate;
            ProductId = photo.FldProductId;
            CustomerId = photo.FldCustomerId;
            RouteId = photo.FldRouteId;
            Id = photo.FldId;
            Type = photo.FldType;
            Latitude = photo.FldLatitude;
            Longitude = photo.FldLongitude;
            InvoiceId = photo.FldInvoiceId;
            PaymentId = photo.FldPaymentId;
            VisitId = photo.FldVisitId;
            ExpenseId = photo.FldExpenseId;
            CategoryId = photo.FldCategoryId;
            AssetId = photo.FldAssetId; // I did not add special field for Asset in photo
            VanId = photo.FldVanId;
            EmployeeId = photo.FldEmployeeId;
            PromotionOfferId = photo.FldPromotionOfferId;
        }

    }
}
