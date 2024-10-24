namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#component_group"/>
    /// </summary>
    [System.Serializable]
    public struct ComponentGroup
    {
        /// <summary>
        /// The unique id of the component section.
        /// </summary>
        public string id;

        /// <summary>
        /// The unix timestamp when the component group was created.
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
    }
}