using App9M.Entity;
using App9M.Entity.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace App9M.Data
{
    public class DataService : iDataService
    {
        private readonly DataContext dataContext;
        public string BaseUrl { get; set; }
        public List<tblUrlList> UrlList { get; set; }
        public List<tblParameters> parameters { get; set; }
        public tblUrlList LoginUrl { get; set; }
        public List<tblHeaders> headers { get; set; }
        public DataService(DataContext _dataContext)
        {
            dataContext = _dataContext;
            dataContext.Database.EnsureCreated();

            setLoginUrl();
        }
        private void setLoginUrl()
        {
            var burl = dataContext.tblSettings.Where(x => x.Name == "BaseUrl").FirstOrDefault();
            BaseUrl = burl == null ? string.Empty : burl.Description;

            var lType = dataContext.tblSettings.Where(x => x.Name == "LoginReqType").FirstOrDefault();
            var lUrl = dataContext.tblSettings.Where(x => x.Name == "LoginUrl").FirstOrDefault();
            var lReqJson = dataContext.tblSettings.Where(x => x.Name == "LoginReqJson").FirstOrDefault();

            if (lType != null && lUrl != null && lReqJson != null)
            {
                LoginUrl = new tblUrlList
                {
                    Id = 0,
                    Name = "[" + lType == null ? "GET" : lType.Description
                        + "]" + lUrl == null ? string.Empty : lUrl.Description,
                    ReqType = lType == null ? "GET" : lType.Description,
                    Url = lUrl == null ? string.Empty : lUrl.Description,
                    ReqJson = lReqJson == null ? string.Empty : lReqJson.Description
                };
            }
        }
        public void refreshLoginUrl() => setLoginUrl();
        public string getValueFromJSONString(string JSONString, string jsonPath)
        {
            if (string.IsNullOrEmpty(JSONString) || string.IsNullOrEmpty(jsonPath))
                return string.Empty;

            var paths = jsonPath.Split('.').ToList();
            var currentPath = paths.FirstOrDefault();
            if (currentPath == null)
                return string.Empty;

            var nextPath = jsonPath.Remove(0, currentPath.Length + ((paths.Count > 1) ? 1 : 0));
            var dSer = JsonConvert.DeserializeObject(JSONString);
            JObject data;

            if (currentPath.EndsWith("]"))
            {
                var index = getIndex(currentPath);
                var arr = (JArray)dSer;
                data = (JObject)arr[index];
            }
            else
            {
                data = (JObject)dSer;
            }

            if (!string.IsNullOrEmpty(nextPath))
            {
                data = !currentPath.EndsWith("]") ? (JObject)data[currentPath] : data;

                return getValueFromJSONString(JsonConvert.SerializeObject(data), nextPath);
            }

            return data[currentPath].Value<string>();
        }
        private int getIndex(string path)
        {
            var st = path.IndexOf("[") + 1;
            var en = path.IndexOf("]");
            var indexStr = path.Substring(st, en - st);
            if (indexStr.Length > 0)
                return Convert.ToInt32(indexStr);
            return 0;
        }
        public bool SetSettingValue(string name, string value)
        {
            var item = dataContext.tblSettings.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                dataContext.tblSettings.Add(new tblSettings
                {
                    Name = name,
                    Description = value,
                    CreatedDate = DateTime.Now,
                });
            }
            else
            {
                item.Description = value;
                item.UpdatedDate = DateTime.Now;
                dataContext.Update(item);
            }
            return dataContext.SaveChanges() > 0;
        }
        public RestResponse? ExecuteRequest(string reqType, string baseUrl, 
            string apiPath, string msgBody)
        {
            var httpClient = new RestClient(baseUrl);
            var request = new RestRequest(apiPath);
            RestResponse? msg;
            switch (reqType)
            {
                case "GET":
                    msg = httpClient.ExecuteGet(request);
                    break;
                case "POST":
                    request.AddJsonBody(msgBody);
                    msg = httpClient.ExecutePost(request);
                    break;
                case "PUT":
                    request.AddJsonBody(msgBody);
                    msg = httpClient.ExecutePut(request);
                    break;
                case "DELETE":
                    msg = httpClient.ExecuteDelete(request);
                    break;
                case "PATCH":
                    request.AddJsonBody(msgBody);
                    msg = httpClient.ExecutePatch(request);
                    break;
                default:
                    msg = null;
                    break;
            }
            return msg;
        }
        public Dictionary<string, string?> GetHeadersFromMsg(RestResponse? msg)
        {
            Dictionary<string, string?> Headers = [];
            if (msg != null && msg.ResponseStatus == ResponseStatus.Completed)
            {
                var ReqHeaders = msg!.Headers!.Select(x => new { x.Name, x.Value }).ToList();
                foreach (var Header in ReqHeaders)
                {
                    if (!string.IsNullOrEmpty(Header.Name) && !string.IsNullOrEmpty(Header.Value))
                        Headers.Add(Header.Name, Header.Value);
                }
            }
            return Headers;
        }
        public string? GetRespBody(RestResponse? msg)
        {
            if(msg == null)
                return string.Empty;
            if(msg.ResponseStatus == ResponseStatus.Completed)
                return msg.Content;
            return msg.ToString();
        }
        public string GetFinalValue(string headerValue) => parameters
            .Aggregate(headerValue,
                (current, item)
                    => current.Replace($"«{item.Name}»", item.FinalValue));
    }
}
