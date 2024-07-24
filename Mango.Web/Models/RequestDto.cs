using static Mango.Web.Utility.SD;

namespace Mango.Web.Models
{
    //v.24
    //comman request DTO 
    public class RequestDto
    {
        //defines if it is GET, POST, PUT or DELETE request
        public ApiType ApiType { get; set; } = ApiType.GET;
        //url of request
        public string Url { get; set; }

        //data will populate from here when we are posting or updating some records
        public object Data { get; set; }
        public string AccessToken { get; set; }

        public ContentType ContentType { get; set; } = ContentType.Json;
    }
}
