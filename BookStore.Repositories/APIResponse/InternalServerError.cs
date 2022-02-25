
namespace BookStore.Repositories.APIResponse
{
    using System.Net;

    /// <summary>
    /// Internal Servor Error.
    /// </summary>
    public class InternalServerError : ResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerError"/> class.
        /// </summary>
        public InternalServerError()
            : base(500, HttpStatusCode.InternalServerError.ToString())
        {
        }
    }
}
