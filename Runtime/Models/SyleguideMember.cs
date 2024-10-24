namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#styleguide_member"/>
    /// </summary>
    [System.Serializable]
    public struct SyleguideMember
    {
        /// <summary>
        /// Member.
        /// </summary>
        public User user;

        /// <summary>
        /// The role of the user in the style guide.
        /// </summary>
        public Role role;
    }
}