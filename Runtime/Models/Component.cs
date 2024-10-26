namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#component"/>
    /// </summary>
    [System.Serializable]
    public struct Component
    {
        /// <summary>
        /// The unique id of the component.
        /// </summary>
        public string id;

        /// <summary>
        /// The name of the component.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the component. Optional.
        /// </summary>
        public string description;

        /// <summary>
        /// Image of the component.
        /// </summary>
        public Image image;

        /// <summary>
        /// The unix timestamp when the component was created.
        /// </summary>
        public int created;

        /// <summary>
        /// The unix timestamp when the component was updated. Optional.
        /// </summary>
        public int updated;

        /// <summary>
        /// Section of the component. Optional.
        /// </summary>
        public Section section;

        /// <summary>
        /// Section of the component.
        /// </summary>

        [System.Serializable]
        public struct Section
        {
            /// <summary>
            /// Unique id of the section that contains the component.
            /// </summary>
            public string id;

            /// <summary>
            /// Unique identifier of the group that contains the component.
            /// Optional.
            /// </summary>
            public Identifier group;
        }
    }
}