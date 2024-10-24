namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Grid.
    /// </summary>
    [System.Serializable]
    public struct Grid
    {
        /// <summary>
        /// Horizontal offset.
        /// </summary>
        public float horizontalOffset;

        /// <summary>
        /// Vertical.
        /// </summary>
        public Vertical vertical;

        /// <summary>
        /// Horizontal.
        /// </summary>
        public Horizontal horizontal;

        /// <summary>
        /// Vertical.
        /// </summary>

        [System.Serializable]
        public struct Vertical
        {
            /// <summary>
            /// Gutter Width.
            /// </summary>
            public float gutterWidth;

            /// <summary>
            /// Width of the column.
            /// </summary>
            public float columnWidth;

            /// <summary>
            /// Number of colors.
            /// </summary>
            public float numberOfColors;

            /// <summary>
            /// Whether the gutter is on outside.
            /// </summary>
            public bool guttersOnOutside;
        }

        /// <summary>
        /// Horizontal.
        /// </summary>

        [System.Serializable]
        public struct Horizontal
        {
            /// <summary>
            /// Gutter Height.
            /// </summary>
            public float gutterHeight;

            /// <summary>
            /// Height of the row.
            /// </summary>
            public float rowHeight;
        }
    }
}