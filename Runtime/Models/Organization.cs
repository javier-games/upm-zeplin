namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#organization"/>
    /// </summary>
    [System.Serializable]
    public struct Organization
    {
        /// <summary>
        /// Organization's unique id.
        /// </summary>
        public string id;

        /// <summary>
        /// Name of the user.
        /// </summary>
        public string name;

        /// <summary>
        /// URL of the organization's logo. Optional.
        /// </summary>
        public string logo;

        /// <summary>
        /// Members of the organization (Does not exist on the response when
        /// user is restricted in organization). Optional.
        /// </summary>
        public OrganizationMember[] members;
    }
}