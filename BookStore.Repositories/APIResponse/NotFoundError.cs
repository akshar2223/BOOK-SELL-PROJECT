namespace BookStore.Repositories.APIResponse
{
    using System.Net;

    /// <summary>
    /// Not Found Error.
    /// </summary>
    public class NotFoundError : ResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError"/> class.
        /// </summary>
        public NotFoundError()
            : base(404, HttpStatusCode.NotFound.ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError"/> class.
        /// </summary>
        public NotFoundError(string message)
            : base(404,HttpStatusCode.NotFound.ToString(),null,message)
        {
        }
    }
}
