namespace BookStore.Repositories.APIResponse
{
    using System.Net;
    using Newtonsoft.Json;

    /// <summary>
    /// Common Response Details Class.
    /// </summary>
    public class ResponseDetails
    {
        /// <summary>
        ///  Gets get set Code.
        /// </summary>
        public int Code { get; private set; } = (int)HttpStatusCode.OK;

        /// <summary>
        ///  Gets get set Description.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; private set; } = HttpStatusCode.OK.ToString();

        /// <summary>
        ///  Gets get set Data.
        /// </summary>
        public dynamic Data { get; private set; } = null;

        /// <summary>
        ///  Gets get set Message.
        /// </summary>
        public string Message { get; private set; } = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetails"/> class.
        /// </summary>
        /// <param name="statusCode">statusCode as Int.</param>
        /// <param name="statusDescription">statusDescription as string.</param>
#pragma warning disable SA1201 // Elements should appear in the correct order
        public ResponseDetails(int statusCode, string statusDescription)
#pragma warning restore SA1201 // Elements should appear in the correct order
        {
            this.Code = statusCode;
            this.Description = statusDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetails"/> class.
        /// </summary>
        /// <param name="statusCode">statusCode as Int.</param>
        /// <param name="statusDescription">statusDescription as string.</param>
        /// <param name="data">data as dynamic.</param>
        public ResponseDetails(int statusCode, string statusDescription, dynamic data)
            : this(statusCode, statusDescription)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetails"/> class.
        /// </summary>
        /// <param name="statusCode">statusCode as Int.</param>
        /// <param name="statusDescription">statusDescription as string.</param>
        /// <param name="data">data as dynamic.</param>
        /// <param name="message">message as string.</param>
        public ResponseDetails(int statusCode, string statusDescription, dynamic data, string message)
            : this(statusCode, statusDescription)
        {
            this.Data = data;
            this.Message = message;
        }
    }
}
