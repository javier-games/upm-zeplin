namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Content.
    /// </summary>
    [System.Serializable]
    public struct Content
    {
        /// <summary>
        /// URL of the asset content.
        /// </summary>
        public string url;

        /// <summary>
        /// Format of the asset content.
        /// </summary>
        public Format format;

        /// <summary>
        /// Density of the asset content. Optional.
        /// </summary>
        public float density;

        /// <summary>
        /// Format of the asset content.
        /// </summary>
        public enum Format
        {
            PNG,
            JPG,
            SVG,
            PDF
        }
    }
}