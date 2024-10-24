namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#spacing_section"/>
    /// </summary>
    [System.Serializable]
    public struct SpacingSection
    {
        /// <summary>
        /// The unique id of the section.
        /// </summary>
        public string id;

        /// <summary>
        /// The name of the section.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the section. Optional.
        /// </summary>
        public string description;

        /// <summary>
        /// Unique id of the base token of the section.
        /// </summary>
        public Identifier baseToken;
    }
}