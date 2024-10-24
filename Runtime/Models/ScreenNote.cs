namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso creh="https://docs.zeplin.dev/reference#screen_note"/>
    /// </summary>
    [System.Serializable]
    public struct ScreenNote
    {
        /// <summary>
        /// The unique id of the note.
        /// </summary>
        public string id;

        /// <summary>
        /// Creator of the screen note.
        /// </summary>
        public User creator;

        /// <summary>
        /// Order of the note in the screen (e.g., 1, 2, 3, so on).
        /// </summary>
        public int order;

        /// <summary>
        /// Status of the note.
        /// </summary>
        public Status status;

        /// <summary>
        /// Position of the note with respect to top left corner. Values
        /// are normalized in [0, 1].
        /// </summary>
        public Position position;

        /// <summary>
        /// Color of the screen note.
        /// </summary>
        public SimpleColor color;

        /// <summary>
        /// Comments on note.
        /// </summary>
        public Comment[] comments;

        /// <summary>
        /// The unix timestamp when the note was created
        /// </summary>
        public int created;

        /// <summary>
        /// Status of the note.
        /// </summary>
        public enum Status
        {
            OPEN,
            RESOLVED
        }

        /// <summary>
        /// Position of the note with respect to top left corner. Values
        /// are normalized in [0, 1]
        /// </summary>

        [System.Serializable]
        public struct Position
        {
            public float x;
            public float y;
        }
    }
}