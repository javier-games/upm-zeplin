namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <see href="https://docs.zeplin.dev/reference#organization_summary"/>
    /// </summary>
    [System.Serializable]
    public struct OrganizationSummary
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
    }
}