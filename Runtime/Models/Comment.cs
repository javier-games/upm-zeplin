namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// Comment.
    /// </summary>
    [System.Serializable]
    public struct Comment
    {
        /// <summary>
        /// Unique id of the comment.
        /// </summary>
        public string id;

        /// <summary>
        /// Content of the comment.
        /// </summary>
        public string content;

        /// <summary>
        /// Author of the comment.
        /// </summary>
        public User author;

        /// <summary>
        /// The unix timestamp when the comment was updated.
        /// </summary>
        public int updated;
    }
}