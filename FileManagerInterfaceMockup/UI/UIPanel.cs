using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup.UI
{
    internal abstract class UIPanel
    {
        protected ConsoleColor backgroundColorUI;
        protected ConsoleColor foregroundColorUI;
        abstract public void Draw(int left, int top);
    }
}
