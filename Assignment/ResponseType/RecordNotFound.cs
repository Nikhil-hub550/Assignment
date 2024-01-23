namespace Assignment.ResponseType
{
    public class RecordNotFound : ResponseBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="message">Response Message. Nullable.</param>
        /// <remarks>Response type for NoContent response</remarks>
        public RecordNotFound(string? message = "NoContent") :
            base(statusCode: StatusCodes.Status204NoContent, succeeded: true, message: message)
        {

        }
    }
}
