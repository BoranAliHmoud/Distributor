namespace IDCoreTest.Helpers
{
    public class ResponseStatusModel
    {
        public bool IsSuccess { get; set; } = false;

        public string StatusMsg { get; set; }

        public string Url { get; set; }

        public IDVErrorCodes ErrorCode { get; set; }

        public void SetResult(bool success, string msg = "", IDVErrorCodes errCode = 0)
        {
            IsSuccess = success;
            StatusMsg = msg;
            ErrorCode = errCode;
        }

    }
  
    public class SubmitResponseStatusModel : ResponseStatusModel
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Object Object { get; set; }
        public void SetResult(bool success, long id, DateTime createDate, string msg = "")
        {
            IsSuccess = success;
            StatusMsg = msg;
            Id = id;
            CreateDate = createDate;
        }

    }
    public class GetResponseStatusModel : ResponseStatusModel
    {
        public object Items { get; set; } = new  object();
    }
    

}
