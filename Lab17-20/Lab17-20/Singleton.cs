using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton getInstance()
        {
            if(instance == null) instance= new Singleton();
            return instance;
        }
    }
    public class App
    {
        public Settings settings;

        public void SetOptions(string[] options)
        {
            Settings.getInstance(options);
        }
    }
    public class Settings
    {
        public static Settings instance;

        public string[] Options { get; private set; }

        protected Settings(string[] options)
        {
            Options = options;
        }
        public static Settings getInstance(string[] options)
        {
            if (instance == null) instance = new Settings(options);
            return instance;
        }
        public string SettingsShow()
        {
            return $"Цвет фона {Options[0]} шрифт {Options[1]} размер {Options[2]}";
        }

    }
}
