namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#layer_color"/>
    /// </summary>
    [System.Serializable]
    public struct LayerColor
    {
        /// <summary>
        /// Name of the color. Optional.
        /// </summary>
        public string name;

        /// <summary>
        /// Red component of the color.
        /// </summary>
        public int r;

        /// <summary>
        /// Green component of the color.
        /// </summary>
        public int g;

        /// <summary>
        /// Blue component of the color.
        /// </summary>
        public int b;

        /// <summary>
        /// Alpha component of the color.
        /// </summary>
        public float a;
    }
}