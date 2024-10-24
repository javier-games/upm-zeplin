namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Gradient.
    /// </summary>
    [System.Serializable]
    public struct Gradient
    {
        /// <summary>
        /// Type of the gradient. Optional.
        /// </summary>
        public Type type;

        /// <summary>
        /// Angle of the gradient. Optional.
        /// </summary>
        public float angle;

        /// <summary>
        /// Scale of the gradient. Optional.
        /// </summary>
        public float scale;

        /// <summary>
        /// Stops af a color.
        /// </summary>
        public ColorStops colorStops;

        /// <summary>
        /// Opacity of gradient. Optional.
        /// </summary>
        public float opacity;

        public enum Type
        {
            LINEAR,
            RADIAL,
            ANGULAR
        }

        /// <summary>
        /// Stops af a color.
        /// </summary>

        [System.Serializable]
        public struct ColorStops
        {
            /// <summary>
            /// Color of the layer.
            /// </summary>
            public LayerColor color;

            /// <summary>
            /// Position.
            /// </summary>
            public float position;
        }
    }
}