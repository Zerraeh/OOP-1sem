using System.Security.Cryptography.X509Certificates;

namespace Lab12
{
    
    internal class Program
    {

        

        static void Main(string[] args)
        {
            SAVDirInfo.onUpdates += SAVLog.WriteLog;
            SAVFileInfo.onUpdates += SAVLog.WriteLog;
            SAVFileInfo.onUpdates += SAVLog.WriteLog;
            SAVFileManager.onUpdates += SAVLog.WriteLog;


            SAVDiskInfo.FreeSpaceShow(@"D:\");
            SAVDiskInfo.AllDrivesInfoShow();
            SAVDiskInfo.FileSystemInfoShow(@"C:\");


            SAVFileInfo.FullPathShow(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVlogfile.txt");
            SAVFileInfo.SizeExtensionShow(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVlogfile.txt");
            SAVFileInfo.FileDatesShow(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVlogfile.txt");


            SAVDirInfo.CreationTimeShow(@"D:\_work\ООП\1sem\Lab12\Lab12\");
            SAVDirInfo.NumberOfFilesShow(@"D:\_work\ООП\1sem\Lab12\Lab12\");
            SAVDirInfo.NumberOfSubdirectoriesShow(@"D:\_work\ООП\1sem\Lab12\Lab12\");
            SAVDirInfo.ParentDirShow(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVlogfile.txt");


            SAVFileManager.DiskInspect(@"D:\");
            SAVFileManager.Copy(@"D:\_work\ООП\1sem\Lab12\Lab12\", ".txt");
            SAVFileManager.WinRAR(@"D:\_work\ООП\1sem\Lab12\Lab12\arg", @"D:\_work\ООП\1sem\Lab12\Lab12\uarg");
            
        }
    }
}