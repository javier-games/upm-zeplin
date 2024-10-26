namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Collection of errors in bad request.
    /// </summary>
    [System.Serializable]
    public struct ErrorCollection
    {
        /// <summary>
        /// Collection of errors.
        /// </summary>
        public Error[] errors;
    }
}