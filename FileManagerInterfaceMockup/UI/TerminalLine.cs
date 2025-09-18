using FileManagerInterfaceMockup.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.UI
{
    internal class TerminalLine
    {
        public void Draw(int left, int top)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            DrawUtility.PaintBox(left, top, Console.BufferWidth, top);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(left, top);
            Console.WriteLine("C:\\NC>");
        }
    }
}
