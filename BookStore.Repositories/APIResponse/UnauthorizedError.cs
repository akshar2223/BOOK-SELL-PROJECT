namespace BookStore.Repositories.APIResponse
{
    using System.Net;

    /// <summary>
    /// Unauthorized Error.
    /// </summary>
    public class UnauthorizedError : ResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedError"/> class.
        /// </summary>
        public UnauthorizedError()
            : base(401, HttpStatusCode.Unauthorized.ToString())
        {
        }
    }
}
