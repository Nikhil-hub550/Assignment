namespace Assignment.ResponseType
{
    public class BadRequest : ResponseBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="message">Response Message. Nullable.</param>
        /// <remarks>Response type for BadRequest response</remarks>
        public BadRequest(string? message = "BadRequest") :
            base(statusCode: StatusCodes.Status400BadRequest, succeeded: true, message: message)
        {

        }
    }
}
