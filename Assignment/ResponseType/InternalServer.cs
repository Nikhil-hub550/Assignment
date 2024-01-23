using System.Reflection;
namespace Assignment.ResponseType
{
    public class InternalServer : ResponseBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="message">Response Message. Nullable.</param>
        /// <remarks>Response type for Internal Error response</remarks>      
        public InternalServer(string? message = "System Error", Exception? ex = null)
            : base(StatusCodes.Status500InternalServerError, false, message)
        {
            
        }
    }
}
