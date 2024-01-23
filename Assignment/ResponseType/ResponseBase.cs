namespace Assignment.ResponseType
{
    public class ResponseBase
    {
        public ResponseBase(int statusCode, bool succeeded, string? message)
        {
            StatusCode = statusCode;
            Succeeded = succeeded;
            Message = message;
        }

        /// Status Code for Response
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Boolean Flag of the request execution status
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Response message
        /// </summary>
        public string? Message { get; set; }
    }
}
