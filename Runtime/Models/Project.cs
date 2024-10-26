namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#project"/>
    /// </summary>
    [System.Serializable]
    public struct Project
    {
        /// <summary>
        /// The unique id of the project.
        /// </summary>
        public string id;

        /// <summary>
        /// The name of the project.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the project. Optional.
        /// </summary>
        public string description;

        /// <summary>
        /// The target platform of the project.
        /// </summary>
        public Platform platform;

        /// <summary>
        /// URL of the project's thumbnail image. Optional.
        /// </summary>
        public string thumbnail;

        /// <summary>
        /// The status of the project.
        /// </summary>
        public Status status;

        /// <summary>
        /// Organization.
        /// </summary>
        public OrganizationSummary organization;

        /// <summary>
        /// URL of the project's scene (public projects only). Optional.
        /// </summary>
        public string sceneUrl;

        /// <summary>
        /// The unix timestamp when the project was created.
        /// </summary>
        public int created;

        /// <summary>
        /// The unix timestamp when the project was updated. Optional.
        /// </summary>
        public int updated;

        /// <summary>
        /// The number of members of the project.
        /// </summary>
        public int numberOfMembers;

        /// <summary>
        /// The number of screens in the project.
        /// </summary>
        public int numberOfScreens;

        /// <summary>
        /// The number of components exported to the project.
        /// </summary>
        public int numberOfComponents;

        /// <summary>
        /// The number of text styles added to the project.
        /// </summary>
        public int numberOfTextStyles;

        /// <summary>
        /// The number of colors added to the project.
        /// </summary>
        public int numberOfColors;

        /// <summary>
        /// Unique id of the style guide which the project is linked to.
        /// Optional.
        /// </summary>
        public Identifier linkedStyleguide;

        /// <summary>
        /// The status of the project.
        /// </summary>
        public enum Status
        {
            ACTIVE,
            ARCHIVED
        }
    }
}