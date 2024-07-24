namespace Mango.Services.CouponAPI.Models.Dto
{

    //one response class to get same response from all microservice
    //for comman response in all the APIs
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
