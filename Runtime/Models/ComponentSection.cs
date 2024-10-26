namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#component_section"/>
    /// </summary>
    [System.Serializable]
    public struct ComponentSection
    {
        /// <summary>
        /// The unique id of the component section.
        /// </summary>
        public string id;

        /// <summary>
        /// The unix timestamp when the component section was created.
        /// </summary>
        public int created;

        /// <summary>
        /// The name of the component section.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the component section. Optional.
        /// </summary>
        public string description;

        /// <summary>
        /// Groups of component section.
        /// </summary>
        public ComponentGroup[] groups;
    }
}