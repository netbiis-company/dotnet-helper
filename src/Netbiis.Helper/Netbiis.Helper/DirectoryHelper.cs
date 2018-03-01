using System.IO;

namespace Netbiis.Helper
{
    public static class DirectoryHelper
    {
        /// <summary>
        ///     Clears the content of the folder.
        /// </summary>
        /// <param name="folderPath">The folder path.</param>
        public static void ClearFolderContent(string folderPath)
        {
            var directory = new DirectoryInfo(folderPath);

            foreach (var file in directory.GetFiles())
                file.Delete();

            foreach (var dir in directory.GetDirectories())
            {
                ClearFolderContent(dir.FullName);
                dir.Delete();
            }
        }
    }
}
