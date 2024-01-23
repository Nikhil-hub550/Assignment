namespace Assignment.ResponseType
{
    public class CreateSuccess : ResponseBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="message">Response Message. Nullable.</param>
        /// <remarks>Response type for Create response</remarks>
        public CreateSuccess(string? message = "Created") :
            base(statusCode: StatusCodes.Status201Created, succeeded: true, message: message)
        {

        }
    }
}
