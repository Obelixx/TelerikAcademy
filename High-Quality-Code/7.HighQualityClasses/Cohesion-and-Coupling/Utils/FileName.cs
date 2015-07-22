namespace CohesionAndCoupling.Utils
{
    public class FileName
    {
        public FileName(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension = string.Empty;
            string fileNameWithoutExtension = string.Empty;
            if (indexOfLastDot == -1)
            {
                extension = string.Empty;
                fileNameWithoutExtension = fileName;
            }
            else
            {
                extension = fileName.Substring(indexOfLastDot + 1);
                fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            }

            this.Name = fileNameWithoutExtension;
            this.Extension = extension;
        }

        public string Name { get; private set; }

        public string Extension { get; private set; }
        
        public static string GetFileName(string fileName)
        {
            return new FileName(fileName).Name;
        }

        public static string GetExtension(string fileName)
        {
            return new FileName(fileName).Extension;
        }
    }
}
