namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#layer_text_style"/>
    /// </summary>
    [System.Serializable]
    public struct LayerTextStyle
    {
        /// <summary>
        /// PostScript name of the text style, e.g. Roboto-Regular.
        /// </summary>
        public string postscriptName;

        /// <summary>
        /// Font family of the text style, e.g. Roboto, Arial.
        /// </summary>
        public string fontFamily;

        /// <summary>
        /// Font size of the text style.
        /// </summary>
        public float fontSize;

        /// <summary>
        /// Font weight of the text style, e.g. 500, 700.
        /// </summary>
        public float fontWeight;

        /// <summary>
        /// Font style of the text style, e.g. italic, oblique.
        /// </summary>
        public string fontStyle;

        /// <summary>
        /// Font stretch form of the text style, e.g. 0.75, 1.00.
        /// </summary>
        public float fontStretch;

        /// <summary>
        /// Minimum height of a line for the text style. Optional.
        /// </summary>
        public float lineHeight;

        /// <summary>
        /// Spacing between letters. Optional.
        /// </summary>
        public float letterSpacing;

        /// <summary>
        /// Horizontal alignment of the text style, left, right, center
        /// or justify. Optional.
        /// </summary>
        public TextAlign textAlign;

        /// <summary>
        /// Color of the layer text style. Optional.
        /// </summary>
        public SimpleColor color;
    }
}