namespace Assignment.ResponseType
{
    public class NotFound : ResponseBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="message">Response Message. Nullable.</param>
        /// <remarks>Response type for Not Found response</remarks>
        public NotFound(string? message = "No Found") :
            base(statusCode: StatusCodes.Status404NotFound, succeeded: true, message: message)
        {

        }
    }
}
