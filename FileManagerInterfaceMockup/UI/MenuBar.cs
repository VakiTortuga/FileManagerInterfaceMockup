using FileManagerInterfaceMockup.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.UI
{
    internal class MenuBar
    {
        string[] menuList;

        protected ConsoleColor backgroundColorUI;
        protected ConsoleColor foregroundColorUI;
        private ConsoleColor upperCaseColorUI;
        private string space;

        public MenuBar() 
        {
            this.foregroundColorUI = ConsoleColor.Black;
            this.backgroundColorUI = ConsoleColor.DarkCyan;
            this.upperCaseColorUI = ConsoleColor.Green;
            this.space = "    ";
            this.menuList = new string[] {"Левая", "Файл", "Диск", "Команды", "Правая" };
        }

        public void Draw(int left, int top)
        {
            Console.BackgroundColor = this.backgroundColorUI;
            DrawUtility.PaintBox(left, top, 79, top);

            Console.SetCursorPosition(left, top);
            foreach (string item in menuList)
            {
                Console.Write(space);
                PrintOneWord(item, upperCaseColorUI, foregroundColorUI);
            }
        }

        private void PrintOneWord(string word, ConsoleColor up, ConsoleColor low)
        {
            Console.ForegroundColor = up;
            Console.Write(word[0]);
            Console.ForegroundColor = low;
            Console.Write(word.Substring(1));
        }
    }
}
