using App9M.Entity.Models;
using RestSharp;

namespace App9M.Data
{
    public interface iDataService
    {
        public string BaseUrl { get; set; }
        public List<tblParameters> parameters { get; set; }
        public List<tblUrlList> UrlList { get; set; }
        public List<tblHeaders> headers { get; set; }
        public tblUrlList LoginUrl { get; set; }
        public void refreshLoginUrl();
        public string getValueFromJSONString(string JSONString, string jsonPath);
        public bool SetSettingValue(string name, string value);
        public RestResponse? ExecuteRequest(string reqType, string baseUrl, string apiPath, string msgBody);
        public Dictionary<string, string?> GetHeadersFromMsg(RestResponse? msg);
        public string? GetRespBody(RestResponse? msg);
        public string GetFinalValue(string headerValue);
    }
}
