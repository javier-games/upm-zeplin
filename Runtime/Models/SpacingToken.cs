namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#spacing_token"/>
    /// </summary>
    [System.Serializable]
    public struct SpacingToken
    {
        /// <summary>
        /// The unique id of the token
        /// </summary>
        public string id;

        /// <summary>
        /// The name of the token.
        /// </summary>
        public string name;

        /// <summary>
        /// The value of the token.
        /// </summary>
        public float number;

        /// <summary>
        /// Color of the spacing token.
        /// </summary>
        public SimpleColor color;

        /// <summary>
        /// Unique id of the section that contains the token.
        /// </summary>
        public Identifier section;
    }
}