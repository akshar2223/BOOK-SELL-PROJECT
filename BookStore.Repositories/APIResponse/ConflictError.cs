namespace BookStore.Repositories.APIResponse
{
    using System.Net;

    /// <summary>
    /// Conflict Error.
    /// </summary>
    public class ConflictError : ResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictError"/> class.
        /// </summary>
        public ConflictError()
            : base(409, HttpStatusCode.Conflict.ToString())
        {
        }
    }
}
