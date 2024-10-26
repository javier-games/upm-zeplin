namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#project_member"/>
    /// </summary>
    [System.Serializable]
    public struct ProjectMember
    {
        /// <summary>
        /// User.
        /// </summary>
        public User user;

        /// <summary>
        /// The role of the user in the project.
        /// </summary>
        public Role role;
    }
}