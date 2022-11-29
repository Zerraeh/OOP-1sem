using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab12
{
    public static class SAVFileManager
    {
        /* Создать класс XXXFileManager.Набор методов определите
 самостоятельно.С его помощью выполнить следующие действия:
 a.Прочитать список файлов и папок заданного диска.Создать
 директорий XXXInspect, создать текстовый файл
 xxxdirinfo.txt и сохранить туда информацию.Создать
 копию файла и переименовать его. Удалить
 первоначальный файл.
 b.Создать еще один директорий XXXFiles.Скопировать в
 него все файлы с заданным расширением из заданного
 пользователем директория. Переместить XXXFiles в
 XXXInspect.
 c.Сделайте архив из файлов директория XXXFiles. 
 Разархивируйте его в другой директорий*/
        public static event Action<string> onUpdates;

       public static void DiskInspect(string diskName)
        {
            Directory.CreateDirectory(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect");

            var currentDisk = DriveInfo.GetDrives().Single(x => x.Name == diskName);
            onUpdates($"[LOG] Файловый менеджер создал директорию {currentDisk.Name}");
            File.Create(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVdirinfo.txt").Close();

            var stream = new StreamWriter(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVdirinfo.txt");

            stream.WriteLine("Dirs: ");
            foreach(var item in currentDisk.RootDirectory.GetDirectories()) 
            {
                stream.WriteLine($"{item.Name}"); 
            }

            stream.WriteLine("Files: ");

            foreach (var item in currentDisk.RootDirectory.GetFiles())
            {
                stream.WriteLine($"{item.Name}");
            }
            File.Copy(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVdirinfo.txt", @"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVdirinfocopy.txt");

            File.Delete(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVdirinfo.txt");

        }
        public static void Copy(string path, string ext)
        {
            var dir = new DirectoryInfo(path);
            Directory.CreateDirectory(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVFiles");

            foreach (var file in dir.GetFiles())
            {
                if (file.Extension == ext)
                {
                    file.CopyTo($@"D:\_work\ООП\1sem\Lab12\Lab12\SAVFiles\{file.Name}");
                    Directory.Delete(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVFiles\");
                    Directory.Move(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVFiles\", @"D:\_work\ООП\1sem\Lab12\Lab12\SAVInspect\SAVFiles\");
                }
            }
            onUpdates($"[LOG] Файловый менеджер скопировал {ext} файлы из {path}");
        }

        public static void WinRAR(string pathFrom, string pathTo)
        {
            Directory.Delete(@"D:\_work\ООП\1sem\Lab12\Lab12\Unarchivive\");
            if (!File.Exists($@"{ pathFrom}.zip"))
            {
                ZipFile.CreateFromDirectory(pathFrom, $@"{pathFrom}.zip");

            }
                ZipFile.ExtractToDirectory($@"{pathFrom}.zip", pathTo);
            onUpdates($"[LOG] Файловый менеджер заархивировал файлы из {pathFrom} и разархивировал в {pathTo}");
        }
    }
}
