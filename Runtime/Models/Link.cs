namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Screen links.
    /// </summary>
    [System.Serializable]
    public struct Link
    {
        /// <summary>
        /// Bounding rectangle of the link's hot spot.
        /// </summary>
        public Rect rect;

        /// <summary>
        /// Destination of the link.
        /// </summary>
        public Destination destination;

        /// <summary>
        /// Destination of a link.
        /// </summary>

        [System.Serializable]
        public struct Destination
        {
            /// <summary>
            /// Destination name.
            /// </summary>
            public string name;

            /// <summary>
            /// Type of the link (screen or previous).
            /// </summary>
            public Type type;

            /// <summary>
            /// Type of the link (screen or previous).
            /// </summary>
            public enum Type
            {
                SCREEN,
                PREVIOUS
            }
        }
    }
}