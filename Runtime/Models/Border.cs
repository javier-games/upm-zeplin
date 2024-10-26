namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Border of a layer.
    /// </summary>
    [System.Serializable]
    public struct Border
    {
        /// <summary>
        /// Position of the border. Optional.
        /// </summary>
        public Position position;

        /// <summary>
        /// Thickness of the border. Optional.
        /// </summary>
        public float thickness;

        /// <summary>
        /// Fill of the border. Optional.
        /// </summary>
        public LayerFill fill;

        /// <summary>
        /// Position of the border.
        /// </summary>
        public enum Position
        {
            CENTER,
            INSIDE,
            OUTSIDE
        }
    }
}