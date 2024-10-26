namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#error"/>
    /// </summary>
    [System.Serializable]
    public struct Error
    {
        /// <summary>
        /// A user readable descriptive message for the error.
        /// </summary>
        public string message;

        /// <summary>
        /// A detailed message describing the error. Optional.
        /// </summary>
        public string detail;

        /// <summary>
        /// The unique code for the error. Optional.
        /// </summary>
        public string code;
    }
}