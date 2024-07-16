using System.Net;

namespace ListAPI.DBO
{
    public class BaseResponse
    {
        public HttpStatusCode Status {  get; set; }
        public string Message { get; set; }
    }
}
