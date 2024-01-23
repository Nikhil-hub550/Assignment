namespace Assignment.ResponseType
{
    public class SuccessDataResponse : ResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public SuccessDataResponse(string? message = "Success", object? data = null) :
        base(statusCode: StatusCodes.Status200OK, succeeded: true, message: message)
        {
            Data = data;
        }

        public object? Data { get; set; }

    }
}
