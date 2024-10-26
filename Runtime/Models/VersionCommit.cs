namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso creh="https://docs.zeplin.dev/reference#version_commit"/>
    /// </summary>
    [System.Serializable]
    public struct VersionCommit
    {
        /// <summary>
        /// Commit message for the version.
        /// </summary>
        public string message;

        /// <summary>
        /// Author of the commit. Optional.
        /// </summary>
        public User author;

        /// <summary>
        /// Color of the commit.
        /// </summary>
        public SimpleColor color;
    }
}