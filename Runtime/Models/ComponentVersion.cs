namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#component_version"/>
    /// </summary>
    [System.Serializable]
    public struct ComponentVersion
    {
        /// <summary>
        /// The unique id of the version.
        /// </summary>
        public string id;

        /// <summary>
        /// Creator of the component version. Optional.
        /// </summary>
        public User creator;

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
        /// Background color of the component.
        /// </summary>
        public SimpleColor backgroundColor;

        /// <summary>
        /// Pixel density.
        /// </summary>
        public float densityScale;

        /// <summary>
        /// Links of the component version.
        /// </summary>
        public Link[] links;

        /// <summary>
        /// Grid of the component. Optional.
        /// </summary>
        public Grid grid;

        /// <summary>
        /// Layers of the component version.
        /// </summary>
        public Layer[] layers;

        /// <summary>
        /// Assets of the component version.
        /// </summary>
        public Asset[] assets;

        /// <summary>
        /// The unix timestamp when the component version was created.
        /// </summary>
        public int created;
    }
}