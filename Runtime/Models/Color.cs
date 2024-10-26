namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#color"/>
    /// </summary>
    [System.Serializable]
    public struct Color
    {
        /// <summary>
        /// Identifier of the color.
        /// </summary>
        public string id;

        /// <summary>
        /// The unix timestamp when the color was created.
        /// </summary>
        public int created;

        /// <summary>
        /// Name of the color.
        /// </summary>
        public string name;

        /// <summary>
        /// Red component of the color
        /// </summary>
        public int r;

        /// <summary>
        /// Green component of the color.
        /// </summary>
        public int g;

        /// <summary>
        /// Blue component of the color
        /// </summary>
        public int b;

        /// <summary>
        /// Alpha component of the color
        /// </summary>
        public float a;
    }
}