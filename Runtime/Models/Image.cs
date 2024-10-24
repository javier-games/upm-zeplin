namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Image References.
    /// </summary>
    [System.Serializable]
    public struct Image
    {
        /// <summary>
        /// Width of the screen image.
        /// </summary>
        public string width;

        /// <summary>
        /// Height of the screen image.
        /// </summary>
        public string height;

        /// <summary>
        /// URL of the original image for the screen (from the latest version).
        /// </summary>
        public string originalUrl;
    }
}