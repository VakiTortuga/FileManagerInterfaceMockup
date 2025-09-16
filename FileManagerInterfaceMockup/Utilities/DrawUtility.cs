using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.Utilities
{
    // цвет устанавливать в вызывающей функции
    internal class DrawUtility
    {
        static public void DrawBox(int left, int top, int right, int bottom)
        {
            Console.SetCursorPosition(left, top);
            Console.Write('\u2554');
            for (int i = left + 1; i < right; i++) Console.Write('\u2550');
            Console.Write('\u2557');

            Console.SetCursorPosition(left, bottom);
            Console.Write('\u255A');
            for (int i = left + 1; i < right; i++) Console.Write('\u2550');
            Console.Write('\u255D');

            for (int i = top + 1; i < bottom; i++)
            {
                Console.SetCursorPosition(left, i);
                Console.Write('\u2551');
                Console.SetCursorPosition(right, i);
                Console.Write('\u2551');
            }
        }

        static public void DrawSeparatorHorisontal(int left, int top, int right)
        {
            Console.SetCursorPosition(left, top);
            Console.Write('\u255F');
            for (int i = left + 1; i < right; i++) Console.Write('\u2550');
            Console.Write('\u2562');
        }

        static public void DrawSeparatorVertical(int left, int top, int bottom)
        {
            Console.SetCursorPosition(left, top);
            Console.Write('\u2564');
            for (int i = top + 1; i < bottom; i++)
            {
                Console.SetCursorPosition(left, i);
                Console.Write('\u2551');
            }
            Console.Write('\u2534');
        }
    }
}
