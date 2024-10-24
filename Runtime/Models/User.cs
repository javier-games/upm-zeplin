namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#user"/>
    /// </summary>
    [System.Serializable]
    public struct User
    {
        /// <summary>
        /// User's unique id.
        /// </summary>
        public string id;

        /// <summary>
        /// Email of the user.
        /// </summary>
        public string email;

        /// <summary>
        /// Username of the user.
        /// </summary>
        public string username;

        /// <summary>
        /// Emotar of the user. Optional.
        /// </summary>
        public string emotar;

        /// <summary>
        /// Avatar of the user. Optional.
        /// </summary>
        public string avatar;
    }
}