using FileManagerInterfaceMockup.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.UI
{
    internal class LeftFilePanel : UIPanel
    {
        override public void Draw(int left, int top, int right, int bottom)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            DrawUtility.DrawBox(left, top, right, bottom);
        }
    }
}
