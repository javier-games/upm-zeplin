namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#screen_section"/>
    /// </summary>
    [System.Serializable]
    public struct ScreenSection
    {
        /// <summary>
        /// The unique id of the screen section.
        /// </summary>
        public string id;

        /// <summary>
        /// The unix timestamp when the screen section was created.
        /// </summary>
        public int created;

        /// <summary>
        /// The name of the screen section.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the screen section. Optional.
        /// </summary>
        public string description;
    }
}