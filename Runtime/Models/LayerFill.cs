namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#layer_fill"/>
    /// </summary>
    [System.Serializable]
    public struct LayerFill
    {
        /// <summary>
        /// Type of the fill.
        /// </summary>
        public Type type;

        /// <summary>
        /// Color of the layer. Optional.
        /// </summary>
        public LayerColor color;

        /// <summary>
        /// Gradient of the fill. Optional.
        /// </summary>
        public Gradient gradient;

        /// <summary>
        /// Blend mode. Optional.
        /// </summary>
        public BlendMode blendMode;

        /// <summary>
        /// Type of the fill.
        /// </summary>
        public enum Type
        {
            COLOR,
            GRADIENT
        }
    }
}