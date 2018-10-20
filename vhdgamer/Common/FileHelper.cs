using System.IO;

namespace Vhdgamer.Common
{
    public static class FileHelper
    {
        /// <summary>
        /// Gets the directory size in MB
        /// </summary>
        /// <param name="folderPath">The folder path</param>
        /// <returns>the size in MB</returns>
        public static long CalculateFolderSize(string folderPath)
        {
            var result = GetFolderSize(folderPath);
            result /= 1024 * 1024;
            return result;
        }

        private static long GetFolderSize(string folderPath)
        {
            var result = 0L;
            
            foreach (var file in Directory.GetFiles(folderPath))
            {
                var fileInfo = new FileInfo(file);
                result += fileInfo.Length;
            }

            foreach (var directory in Directory.GetDirectories(folderPath))
            {
                result += GetFolderSize(directory);
            }

            return result;
        }
    }
}