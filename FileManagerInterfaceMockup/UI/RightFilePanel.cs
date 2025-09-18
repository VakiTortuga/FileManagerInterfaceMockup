using FileManagerInterfaceMockup.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.UI
{
    internal class RightFilePanel : UIPanel
    {
        private List<FileSystemItem> files;

        public RightFilePanel()
        {
            files = new List<FileSystemItem>();
            InitFileList();                    
        }

        private void InitFileList()
        {
            files.Add(new FileSystemItem("123view", "exe", 128380, new DateOnly(2002, 10, 11), new TimeOnly(19, 48)));
            files.Add(new FileSystemItem("4372ansipippip", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("8502ansibzjbjh", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("8632ansi", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("8652ansi", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("8662ansi", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("Ajaccgdo\u2592", "", 417392, new DateOnly(2002, 10, 12), new TimeOnly(9, 02)));
            files.Add(new FileSystemItem("ansi2437", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("ansi2850", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("ansi2863", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("ansi2865", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("ansi2866ououou", "set", 255, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("arcview", "exe", 81738, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("bitmappippip", "exe", 54805, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("bug", "nss", 16133, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
            files.Add(new FileSystemItem("bungee", "nss", 41914, new DateOnly(1995, 05, 25), new TimeOnly(5, 00)));
        }

        override public void Draw(int left, int top, int right, int bottom)
        {
            // вывод "каркаса"
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            DrawUtility.DrawBox(left, top, right, bottom);
            DrawUtility.DrawSeparatorHorizontal(left, bottom - 2, right);
            DrawUtility.DrawSeparatorVertical(left + 13, top, bottom - 2);
            DrawUtility.DrawSeparatorVertical(left + 23, top, bottom - 2);
            DrawUtility.DrawSeparatorVertical(left + 32, top, bottom - 2);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(left + ((right - left) / 2) - 3, top);
            Console.Write(" C:\\NC ");
            
            Console.SetCursorPosition(left + 1, top + 2);
            Console.Write("..          \u2502\u25BAКАТАЛОГ\u25C4\u250211.10.02\u2502 19:48");

            // вывод названий колонок
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(left + 1, top + 1);
            Console.Write("C:\u2193 Имя");
            Console.SetCursorPosition(left + 14, top + 1);
            Console.Write("  Размер");
            Console.SetCursorPosition(left + 24, top + 1);
            Console.Write("  Дата");
            Console.SetCursorPosition(left + 33, top + 1);
            Console.Write("Время");

            // вывод выбранного каталога
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(left + 1, bottom - 1);
            Console.Write("..           \u25BAКАТАЛОГ\u25C4 11.10.02  19:48");

            // Вывод таблицы файлов
            for (int i = 0; i < 16; i++)
            {
                DrawFile(41, i + 4, files[i]);
            }
        }

        private void DrawFile(int left, int top, FileSystemItem file)
        {
            string name = file.Name;
            if (name.Length > 11 - file.Type.Length)
            {
                name = name.Substring(0, 7);
                name = name.Insert(7, "~");
            }
            Console.SetCursorPosition(left, top);
            Console.Write(name);
            if (file.Name != "")
            {
                Console.SetCursorPosition(left + 9, top);
                Console.Write(file.Type);
            }
            string size = file.Size.ToString();
            Console.SetCursorPosition(left + 22 - size.Length, top);
            Console.Write(size);
            Console.SetCursorPosition(left + 23, top);
            Console.Write(file.LastModifiedDate.ToString().Substring(3));
            string lastModifiedTime = file.LastModifiedTime.ToString();
            Console.SetCursorPosition(left + 33 + (lastModifiedTime.Length == 4 ? 1 : 0), top);
            Console.Write(lastModifiedTime);
        }
    }
}
