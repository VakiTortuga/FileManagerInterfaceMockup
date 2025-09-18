using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup
{
    internal class FileManager
    {
        private List<FileSystemItem> files;
        
        // Общие параметры окна консоли

        private short windowHight = 25;
        private short windowWidth = 80;

        private short bufferHight = 25;
        private short bufferWidth = 80;

        private ConsoleColor backgroundColor = ConsoleColor.Black;
        private ConsoleColor foregroundColor = ConsoleColor.White;

        string consoleTitle = "File Manager";

        // параметры отображения пользовательского интерфейса

        // Компоненты пользовательского интерфейса
        private UI.MenuBar menuBar;
        private UI.LeftFilePanel leftPanel;
        private UI.RightFilePanel rightPanel;
        private UI.TerminalLine terminalLine;
        private UI.SettingsBar settingsBar;

        // конструктор, задающий начальные параметры отображения
        public FileManager(List<FileSystemItem> _files)
        {
            files = _files;
            menuBar = new UI.MenuBar();
            leftPanel = new UI.LeftFilePanel();
            rightPanel = new UI.RightFilePanel();
            terminalLine = new UI.TerminalLine();
            settingsBar = new UI.SettingsBar();
        }

        // функция для настройки отображения окна консоли
        public void InitialSettings() 
        {
            Console.Title = consoleTitle;
            Console.SetWindowSize(windowWidth, windowHight);
            Console.SetBufferSize(bufferWidth, bufferHight);
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.Clear();
        }

        // Функция для вывода на экран элементов интерфейса
        public void DrawUI()
        {
            this.InitialSettings();
            menuBar.Draw(0, 0);
            leftPanel.Draw(0, 1, 39, 22);
            rightPanel.Draw(40, 1, 79, 22);
            terminalLine.Draw(0, 23);
            settingsBar.Draw(0, 24);
        }
    }
}
