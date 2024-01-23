namespace Assignment.ResponseType
{
    public class SuccessResponse : ResponseBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="message">Response Message. Nullable.</param>
        /// <remarks>Response type for Success response</remarks>
        public SuccessResponse(string? message = "Success") :
            base(statusCode: StatusCodes.Status200OK, succeeded: true, message: message)
        {

        }
    }
}
