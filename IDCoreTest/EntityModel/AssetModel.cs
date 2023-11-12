using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using IDCoreTest.Models;

namespace IDCoreTest 
{
    public class AssetModel : EntityModel
    {
        public long Id;
        public string Name;
        public long CustomerId;
        public long RouteId;
        public long CategoryId;
        public long? BranchId;
        public int Type;
        public int Status;
        public string Description;
        public string Comments;
        public DateTime InstallationDate;
        public double InstallationTimeStamp;
        public double Cost;
        public double? Longitude;
        public double? Latitude;

        public DateTime? LastInspectionDate;

        public List<PhotoModel> Attachments = new List<PhotoModel>();

        public AssetModel() { }

        public AssetModel(TblAsset obj, List<PhotoModel> photos)
        {
            Id = obj.FldId;
            Name = obj.FldName;
            Comments = obj.FldComments;
            Description = obj.FldDescription;
            BranchId = obj.FldBranchId;
            RouteId = obj.FldRouteId ?? 0;
            CustomerId = obj.FldCustomerId ?? 0;
            CategoryId = obj.FldCategoryId ?? 0;

            Latitude = obj.FldLatitude;
            Longitude = obj.FldLongitude;
            Cost = obj.FldCost;
            Status = obj.FldStatus;

            InstallationDate = obj.FldInstallationDate.Value;
            InstallationTimeStamp = Helper.GetTimeStampFromDateTime(obj.FldInstallationDate.Value);
            LastInspectionDate = obj.FldLastInspectionDate;
            Attachments = photos;
        }

        public TblAsset CreateObject()
        {
            //DateTime createTime = Helper.GetDateTimeFromTimeStamp(this.InstallationTimeStamp).Value;

            TblAsset obj = new TblAsset
            {
                FldName = Name,
                FldCustomerId = this.CustomerId,
                FldRouteId = this.RouteId,
                FldCategoryId = this.CategoryId,
                FldInstallationDate = this.InstallationDate,
                FldLatitude = this.Latitude,
                FldLongitude = this.Longitude,
                FldStatus = Status,
                FldComments = Comments,
                FldDescription = Description,

                FldBranchId = this.BranchId,

                FldCreateDate = DateTime.Now,
                FldType = 1
            };

            return obj;
        }
    }
    public class EntityModel
    {
        public override string ToString()
        {
            string json = JsonConvert.SerializeObject(this);
            JToken jt = JToken.Parse(json);
            string formattedJson = jt.ToString();

             return String.Format("Data: {0}", formattedJson);
        }
      
    }
}
