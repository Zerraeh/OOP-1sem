using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class SAVDiskInfo
    {
        /*2. Создать класс XXXDiskInfo c методами для вывода информации о
a.свободном месте на диске
b. Файловой системе
c.Для каждого существующего диска - имя, объем, доступный
объем, метка тома.
d.Продемонстрируйте работу класса*/

        public static void FreeSpaceShow(string disk)
        {
            var currentDisk = DriveInfo.GetDrives().Single(x=> x.Name == disk);
            Console.WriteLine($"Свободное место на диске {disk}: {currentDisk.AvailableFreeSpace} байт...");
        }

        public static void FileSystemInfoShow(string disk)
        {
            var currentDisk = DriveInfo.GetDrives().Single(x => x.Name == disk);
            Console.WriteLine($"Информация о файловой системе диска {disk} : {currentDisk.DriveType}\t-\t{currentDisk.DriveFormat}");
        }


    }
}
