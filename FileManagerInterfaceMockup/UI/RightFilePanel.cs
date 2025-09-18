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
        override public void Draw(int left, int top, int right, int bottom)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            DrawUtility.PaintBox(left, top, right, bottom);
            DrawUtility.DrawBox(left, top, right, bottom);
            DrawUtility.DrawSeparatorHorizontal(left, bottom - 3, right);
            DrawUtility.DrawSeparatorVertical(left + 13, top, bottom - 3);
            DrawUtility.DrawSeparatorVertical(left + 23, top, bottom - 3);
            DrawUtility.DrawSeparatorVertical(left + 32, top, bottom - 3);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(left + ((right - left) / 2) - 3, top);
            Console.Write(" C:\\NC ");

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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(left + 1, bottom - 1);
            Console.Write("..           \u25BAКАТАЛОГ\u25C4 11.10.02  19:48");

        }
    }
}
