namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Blur of a layer.
    /// </summary>
    [System.Serializable]
    public struct Blur
    {
        /// <summary>
        /// Type of the blur. Optional.
        /// </summary>
        public Type type;

        /// <summary>
        /// Radius of the blur. Optional.
        /// </summary>
        public float radius;

        /// <summary>
        /// Type of the blur.
        /// </summary>
        public enum Type
        {
            GAUSSIAN,
            BACKGROUND
        }
    }
}