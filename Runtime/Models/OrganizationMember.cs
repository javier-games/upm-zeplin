namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#organization_member"/>
    /// </summary>
    [System.Serializable]
    public struct OrganizationMember
    {
        /// <summary>
        /// Member.
        /// </summary>
        public User user;

        /// <summary>
        /// The role of the user in the organization.
        /// </summary>
        public Role role;

        /// <summary>
        /// Whether the user's membership is restricted to only the projects
        /// that they are member of.
        /// </summary>
        public bool restricted;
    }
}