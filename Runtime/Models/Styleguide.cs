namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso creh="https://docs.zeplin.dev/reference#styleguide"/>
    /// </summary>
    [System.Serializable]
    public struct Styleguide
    {
        /// <summary>
        /// The unique id of the style guide.
        /// </summary>
        public string id;

        /// <summary>
        /// The name of the style guide.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the style guide (It can contain <seealso href=
        /// "https://zpl.io/article/markdown-support">markdown</seealso>).
        /// Optional.
        /// </summary>
        public string description;

        /// <summary>
        /// The target platform of the style guide.
        /// </summary>
        public Platform platform;

        /// <summary>
        /// URL of the style guides thumbnail image. Optional.
        /// </summary>
        public string thumbnail;

        /// <summary>
        /// The status of the style guide.
        /// </summary>
        public Status status;

        /// <summary>
        /// Organization. Optional.
        /// </summary>
        public OrganizationSummary organization;

        /// <summary>
        /// The unix timestamp when the style guide was created
        /// </summary>
        public int created;

        /// <summary>
        /// The unix timestamp when the style guide was updated. Optional.
        /// </summary>
        public int updated;

        /// <summary>
        /// The number of members of the style guide.
        /// </summary>
        public int numberOfMembers;

        /// <summary>
        /// The number of components exported to the style guide.
        /// </summary>
        public int numberOfComponents;

        /// <summary>
        /// The number of text styles added to the style guide.
        /// </summary>
        public int numberOfTextStyles;

        /// <summary>
        /// The number of colors added to the style guide.
        /// </summary>
        public int numberOfColors;

        /// <summary>
        /// ID of the parent. Optional.
        /// </summary>
        public Identifier parent;

        /// <summary>
        /// The status of the style guide.
        /// </summary>
        public enum Status
        {
            ACTIVE,
            ARCHIVED
        }
    }
}