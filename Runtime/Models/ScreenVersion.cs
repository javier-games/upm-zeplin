namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#screen_version"/>
    /// </summary>
    [System.Serializable]
    public struct ScreenVersion
    {
        /// <summary>
        /// The unique id of the version.
        /// </summary>
        public string id;

        /// <summary>
        /// Creator of the screen. Optional.
        /// </summary>
        public User creator;

        /// <summary>
        /// Information about the version commit. Optional.
        /// </summary>
        public VersionCommit versionCommit;

        /// <summary>
        /// URL of the image for the version. Optional.
        /// </summary>
        public string imageUrl;

        /// <summary>
        /// Source application of the version.
        /// </summary>
        public Source source;

        /// <summary>
        /// Width of the version.
        /// </summary>
        public int width;

        /// <summary>
        /// Height of the version.
        /// </summary>
        public int height;

        /// <summary>
        /// Color of the background. Optional.
        /// </summary>
        public SimpleColor backgroundColor;

        /// <summary>
        /// Pixel density.
        /// </summary>
        public float densityScale;

        /// <summary>
        /// Screen links.
        /// </summary>
        public Link[] links;

        /// <summary>
        /// Grid of the link. Optional.
        /// </summary>
        public Grid grid;

        /// <summary>
        /// Layers of the screen version.
        /// </summary>
        public Layer[] layers;

        /// <summary>
        /// Assets of the screen version.
        /// </summary>
        public Asset[] assets;

        /// <summary>
        /// The unix timestamp when the screen version was created.
        /// </summary>
        public int created;
    }
}