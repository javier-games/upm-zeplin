namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href=
    /// "https://docs.zeplin.dev/reference#screen_version_summary"/>
    /// </summary>
    [System.Serializable]
    public struct ScreenVersionSummary
    {
        /// <summary>
        /// The unique id of the version.
        /// </summary>
        public string id;

        /// <summary>
        /// Creator of the summary version. Optional.
        /// </summary>
        public User creator;

        /// <summary>
        /// Commit of the Version. Optional.
        /// </summary>
        public VersionCommit commit;

        /// <summary>
        /// URL of the image for the version.
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
        /// Pixel density.
        /// </summary>
        public float densityScale;

        /// <summary>
        /// Links of the screen version.
        /// </summary>
        public Link[] links;

        /// <summary>
        /// The unix timestamp when the screen version summary was created.
        /// </summary>
        public int created;
    }
}