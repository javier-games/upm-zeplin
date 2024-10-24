namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#screen"/>
    /// </summary>
    [System.Serializable]
    public struct Screen
    {
        /// <summary>
        /// The unique id of the screen.
        /// </summary>
        public string id;

        /// <summary>
        /// The name of the screen.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the screen. Optional.
        /// </summary>
        public string description;

        /// <summary>
        /// The tags platform of the screen.
        /// </summary>
        public string[] tags;

        /// <summary>
        /// Screen Image.
        /// </summary>
        public Image image;

        /// <summary>
        /// The unix timestamp when the screen was created.
        /// </summary>
        public int created;

        /// <summary>
        /// The unix timestamp when the screen was updated. Optional.
        /// </summary>
        public int updated;

        /// <summary>
        /// The number of versions exported to the screen.
        /// </summary>
        public int numberOfVersions;

        /// <summary>
        /// The number of notes in the screen.
        /// </summary>
        public int numberOfNotes;

        /// <summary>
        /// Unique identifier of the section that contains the screen.
        /// Optional.
        /// </summary>
        public Identifier section;
    }
}