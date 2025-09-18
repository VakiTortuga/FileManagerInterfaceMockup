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
        //есть возможность более явной передачи координат

        //struct Point
        //{
        //    public int x;
        //    public int y;
        //}

        static public void PaintBox(int left, int top, int right, int bottom)
        {
            string line = "".PadRight(right - left + 1, ' '); // линия пробелов нужной ширины

            for (int i = top; i <= bottom; i++) // рисуем столбик из линий
            {
                Console.SetCursorPosition(left, i);
                Console.Write(line);
            }
        }

        static public void DrawBox(int left, int top, int right, int bottom)
        {
            PaintBox(left, top, right, bottom);

            string line = "".PadRight(right - left - 1, '\u2550'); // горизонтальные границы (длина - 2 уголка)
            
            Console.SetCursorPosition(left, top);
            Console.Write('\u2554' + line + '\u2557'); // верхняя граница
            
            Console.SetCursorPosition(left, bottom);
            Console.Write('\u255A' + line + '\u255D'); // нижняя граница

            for (int i = top + 1; i < bottom; i++) // вертикальные границы
            {
                Console.SetCursorPosition(left, i);
                Console.Write('\u2551'); // вертикальная граница
                Console.SetCursorPosition(right, i);
                Console.Write('\u2551');
            }
        }

        static public void DrawSeparatorHorizontal(int left, int top, int right)
        {
            string line = "".PadRight(right - left - 1, '\u2500'); // горизонтальные границы (длина - 2 уголка)
            Console.SetCursorPosition(left, top);
            Console.Write('\u255F'); // левый переходник
            Console.Write(line); // левый переходник            
            Console.Write('\u2562'); // правый переходник
        }

        static public void DrawSeparatorVertical(int left, int top, int bottom)
        {
            Console.SetCursorPosition(left, top);
            Console.Write('\u2564');
            for (int i = top + 1; i < bottom; i++)
            {
                Console.SetCursorPosition(left, i);
                Console.Write('\u2502');
            }
            Console.SetCursorPosition(left, bottom);
            Console.Write('\u2534');
        }
    }
}
