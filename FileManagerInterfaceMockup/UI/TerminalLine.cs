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
            Console.ForegroundColor = ConsoleColor.White;
            DrawUtility.PaintBox(left, top, Console.BufferWidth, top);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("C:\\NC>");
        }
    }
}
