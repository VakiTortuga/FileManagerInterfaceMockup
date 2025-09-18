using FileManagerInterfaceMockup.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.UI
{
    internal class SettingsBar
    {
        string[] settingsList;

        protected ConsoleColor numBackground;
        protected ConsoleColor numForeground;
        protected ConsoleColor textBackground;
        protected ConsoleColor textForeground;

        public SettingsBar()
        {
            this.numBackground = ConsoleColor.Black;
            this.numForeground = ConsoleColor.White;
            this.textBackground = ConsoleColor.DarkCyan;
            this.textForeground = ConsoleColor.Black;
            this.settingsList = new string[] { "Помощь", "Вызов", "Чтение",
                "Правка", "Копия", "НовИмя", "НовКат", "Удал-е", "Меню", "Выход" };
        }

        public void Draw(int left, int top)
        {
            Console.BackgroundColor = this.numBackground;
            DrawUtility.PaintBox(left, top, Console.BufferWidth - 1, top);

            Console.SetCursorPosition(left, top);
            for (int i = 0; i < this.settingsList.Length; i++)
            {
                PrintOneWord($"{i + 1}", numForeground, numBackground);
                PrintOneWord(settingsList[i], textForeground, textBackground);
                PrintOneWord(" ", numForeground, numBackground);
            }
        }

        private void PrintOneWord(string word, ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(word);
        }
    }
}
