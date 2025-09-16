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
        }
    }
}
