namespace Data.Helpers
{
    public static class BlobHelpers
    {
        /// <summary>
        /// Cleans up a Azure Storage virtual folder path
        /// </summary>
        /// <param name="path">Raw virtual folder path</param>
        /// <returns>Normalized and cleaned virtual folder path</returns>
        public static string NormalizeVirtualFolderPath(string path)
        {
            // lower case only (case insensitive)
            // no white spaces
            // no slashes (if prefixed with a slash the SDK / API will never find the folder)
            // use only forward slashes '/'
            return path?.ToLower().Trim().Trim('/').Replace('\\', '/');
        }
    }
}