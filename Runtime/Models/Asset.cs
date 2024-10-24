namespace BricksBucket.Web.Zeplin.Models
{
    /// <summary>
    /// <seealso href="https://docs.zeplin.dev/reference#asset"/>
    /// </summary>
    [System.Serializable]
    public struct Asset
    {
        /// <summary>
        /// Layer's identifier in the design tool. Optional.
        /// </summary>
        public string layerSourceId;

        /// <summary>
        /// Display name of the asset.
        /// </summary>
        public string displayName;

        /// <summary>
        /// Name of the layer containing the asset. Optional.
        /// </summary>
        public string layerName;

        /// <summary>
        /// Content of asset.
        /// </summary>
        public Content[] contents;
    }
}