namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso creh="https://docs.zeplin.dev/reference#layer"/>
    /// </summary>
    [System.Serializable]
    public struct Layer
    {
        /// <summary>
        /// Layer's unique id.
        /// </summary>
        public string id;

        /// <summary>
        /// Layer's identifier in the design tool. Optional.
        /// </summary>
        public string sourceId;

        /// <summary>
        /// Type of the layer.
        /// </summary>
        public Type type;

        /// <summary>
        /// Name of the layer. Optional.
        /// </summary>
        public string name;

        /// <summary>
        /// Bounding rectangle of the layer.
        /// </summary>
        public Rect rect;

        /// <summary>
        /// Fills applied to the layer. Optional.
        /// </summary>
        public LayerFill[] fills;

        /// <summary>
        /// Borders of the layer.
        /// </summary>
        public Border borders;

        /// <summary>
        /// Shadows applied to the layer.
        /// </summary>
        public Shadow shadows;

        /// <summary>
        /// Blur applied to the layer. Optional.
        /// </summary>
        public Blur blur;

        /// <summary>
        /// Opacity of the layer, [0, 1].
        /// </summary>
        public float opacity;

        /// <summary>
        /// Blend Mode. Optional.
        /// </summary>
        public BlendMode blendMode;

        /// <summary>
        /// Border radius of the layer. Optional.
        /// </summary>
        public float borderRadius;

        /// <summary>
        /// Rotation of the layer. Optional.
        /// </summary>
        public float rotation;

        /// <summary>
        /// Indicates whether the layer has assets or not. Optional.
        /// </summary>
        public bool exportable;

        /// <summary>
        /// Text of the text layer. Optional.
        /// </summary>
        public string content;

        /// <summary>
        /// Text Styles.
        /// </summary>
        public TextStyle textStyles;

        /// <summary>
        /// Additional layers. Optional.
        /// </summary>
        public Layer[] layers;

        /// <summary>
        /// Name of the component the group layer is referencing. Optional.
        /// </summary>
        public string componentName;

        /// <summary>
        /// Type of the layer.
        /// </summary>
        public enum Type
        {
            TEXT,
            SHAPE,
            GROUP
        }

        /// <summary>
        /// Text Styles.
        /// </summary>

        [System.Serializable]
        public struct TextStyle
        {
            /// <summary>
            /// Text style range.
            /// </summary>
            public Range range;

            /// <summary>
            /// Layer of the text style.
            /// </summary>
            public LayerTextStyle style;


            [System.Serializable]
            public struct Range
            {
                /// <summary>
                /// Start of the range
                /// </summary>
                public float location;

                /// <summary>
                /// Length of the range.
                /// </summary>
                public float length;
            }
        }
    }
}