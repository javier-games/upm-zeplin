namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#token_response"/>
    /// </summary>
    [System.Serializable]
    public struct TokenResponse
    {
        /// <summary>
        /// Access token that allows you to make requests to the API on behalf
        /// of a user.
        /// </summary>
        public string accessToke;

        /// <summary>
        /// Access token's lifetime in seconds.
        /// </summary>
        public float expiresIn;

        /// <summary>
        /// Refresh token that allows you to obtain access tokens.
        /// </summary>
        public string refreshToke;

        /// <summary>
        /// Refresh token's lifetime in seconds.
        /// </summary>
        public float refreshExpiresIn;

        /// <summary>
        /// Type of the token returned.
        /// </summary>
        public string tokenType;
    }
}