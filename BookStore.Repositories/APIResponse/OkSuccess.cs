namespace BookStore.Repositories.APIResponse
{
    using System.Net;

    /// <summary>
    /// Ok.
    /// </summary>
    public class OkSuccess : ResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OkSuccess"/> class.
        /// </summary>
        public OkSuccess()
            : base(200, HttpStatusCode.OK.ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OkSuccess"/> class.
        /// </summary>
        /// <param name="data">data as dynamic.</param>
        public OkSuccess(object data,string message="")
            : base(200, HttpStatusCode.OK.ToString(), data,message)
        {
        }
    }
}
