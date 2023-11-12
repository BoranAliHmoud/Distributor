using IDCoreTest.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace IDCoreTest 
{
    public class UpsertEntityModel
    {
        public string AccessToken { get; set; }
        public string Lng { get; set; } = "en";
        public ResponseStatusModel ResponseStatus { get; set; } = new ResponseStatusModel();
         
        public Object Entity { get; set; }

        public override string ToString()
        {
            JsonSerializerSettings d = new JsonSerializerSettings
            {
                MaxDepth = 1
            };

            string json = JsonConvert.SerializeObject(Entity, d);
            JToken jt = JToken.Parse(json);
            string formattedJson = jt.ToString();

            return String.Format("AccessToken: {0} - Entity: {1}", AccessToken, formattedJson);

        }

    }
}
