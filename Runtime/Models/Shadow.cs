namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Shadow of a layer.
    /// </summary>
    [System.Serializable]
    public struct Shadow
    {
        /// <summary>
        /// Type of the shadow. Optional.
        /// </summary>
        public Type type;

        /// <summary>
        /// Horizontal offset of the shadow. Optional.
        /// </summary>
        public float offsetX;

        /// <summary>
        /// Vertical offset of the shadow. Optional.
        /// </summary>
        public float offsetY;

        /// <summary>
        /// Blur radius of the shadow. Optional.
        /// </summary>
        public float blurRadius;

        /// <summary>
        /// Spread of the shadow. Optional.
        /// </summary>
        public float spread;

        /// <summary>
        /// Color of the layer. Optional.
        /// </summary>
        public LayerColor color;

        /// <summary>
        /// Type of the shadow.
        /// </summary>
        public enum Type
        {
            OUTER,
            INNER
        }
    }
}