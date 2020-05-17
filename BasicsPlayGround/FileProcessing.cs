using System.IO;

namespace BasicsPlayGround
{
    public class FileProcessing
    {
        public void openFile()
        {
            var FileName = "";
            var fs = File.Open(FileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
        }
    }
}
