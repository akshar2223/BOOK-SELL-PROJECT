namespace BookStore.Repositories.APIResponse
{
    using System.Net;

    /// <summary>
    /// Bad Request Error.
    /// </summary>
    public class BadRequestError : ResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestError"/> class.
        /// </summary>
        public BadRequestError()
            : base(400, HttpStatusCode.BadRequest.ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestError"/> class.
        /// </summary>
        /// <param name="data">data as dynamic.</param>
        public BadRequestError(object data)
            : base(400, HttpStatusCode.BadRequest.ToString(), data)
        {
        }
    }
}
