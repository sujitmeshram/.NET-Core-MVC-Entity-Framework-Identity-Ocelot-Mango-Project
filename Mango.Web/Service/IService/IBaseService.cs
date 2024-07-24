using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    //base comman service for sending requests to the multiple APIs
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
