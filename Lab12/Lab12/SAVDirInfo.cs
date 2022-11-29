using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    /*Создать класс XXXDirInfo c методами для вывода информации о конкретном
директории
a.Количестве файлов
b. Время создания
c.Количестве поддиректориев
d.Список родительских директориев
e. Продемонстрируйте работу класс*/
    public static class SAVDirInfo
    {
        public static event Action<string> onUpdates;

        public static void NumberOfFilesShow(string path)
        {
            Console.WriteLine($"Число файлов:\t{Directory.GetFiles(path).Length}");
            onUpdates($"[LOG] Число файлов:\t{Directory.GetFiles(path).Length} ");
        }

        public static void CreationTimeShow(string path)
        {
            Console.WriteLine($"Время создания:\t{Directory.GetCreationTime(path)}");
            onUpdates($"[LOG] Время создания:\t{Directory.GetCreationTime(path)}");
        }

        public static void NumberOfSubdirectoriesShow(string path)
        {
            Console.WriteLine($"Число поддиректорий:\t{Directory.GetDirectories(path).Length}");
            onUpdates($"[LOG] Число поддиректорий:\t{Directory.GetDirectories(path).Length}");
        }

        public static void ParentDirShow(string path)
        {
            Console.WriteLine($"Список родительских директорий:\t{Directory.GetParent(path)}");
            onUpdates($"[LOG] Список родительских директорий:\t{Directory.GetParent(path)}");
        }
    }
}
