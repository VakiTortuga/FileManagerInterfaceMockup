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
        private List<FileSystemItem> files;

        public LeftFilePanel()
        {
            files = new List<FileSystemItem>();
            InitFileList();
        }

        private void InitFileList()
        {
            files.Add(new FileSystemItem("..", ""));
            files.Add(new FileSystemItem("Ajaccgdo\u2592", ""));
            files.Add(new FileSystemItem("nc", "cfg"));
            files.Add(new FileSystemItem("nc_exit", "com"));
            files.Add(new FileSystemItem("telemax", "dat"));
            files.Add(new FileSystemItem("nc_exit", "doc"));
            files.Add(new FileSystemItem("123view", "exe"));
            files.Add(new FileSystemItem("arcview", "exe"));
            files.Add(new FileSystemItem("bitmap", "exe"));
            files.Add(new FileSystemItem("clp2bib", "exe"));
            files.Add(new FileSystemItem("dbview", "exe"));
            files.Add(new FileSystemItem("draw2wmfpipipi", "exe"));
            files.Add(new FileSystemItem("drw2wmf", "exe"));
            files.Add(new FileSystemItem("ico2dib", "exe"));
            files.Add(new FileSystemItem("ico2dib", "exe"));
            files.Add(new FileSystemItem("nc", "exe"));
            files.Add(new FileSystemItem("ncclean", "exe"));
            files.Add(new FileSystemItem("ncdd", "exe"));
            files.Add(new FileSystemItem("ncedit", "exe"));
            files.Add(new FileSystemItem("ncff", "exe"));
            files.Add(new FileSystemItem("nclabel", "exe"));
            files.Add(new FileSystemItem("ncmainpipi", "exe"));
            files.Add(new FileSystemItem("ncnetpipipi", "exe"));
            files.Add(new FileSystemItem("ncsfpipipi", "exe"));
            files.Add(new FileSystemItem("ncsipipipi", "exe"));
            files.Add(new FileSystemItem("nczip", "exe"));
            files.Add(new FileSystemItem("packer", "exe"));
            files.Add(new FileSystemItem("paraview", "exe"));
            files.Add(new FileSystemItem("pct2dib", "exe"));
            files.Add(new FileSystemItem("playwave", "exe"));
            files.Add(new FileSystemItem("q&aview", "exe"));
            files.Add(new FileSystemItem("rbview", "exe"));
            files.Add(new FileSystemItem("refview", "exe"));
            files.Add(new FileSystemItem("saver", "exe"));
            files.Add(new FileSystemItem("telemax", "exe"));
            files.Add(new FileSystemItem("tif2dib", "exe"));
            files.Add(new FileSystemItem("vector", "exe"));
            files.Add(new FileSystemItem("wpb2dib", "exe"));
            files.Add(new FileSystemItem("wpv2wmf", "exe"));
            files.Add(new FileSystemItem("wpview", "exe"));
            files.Add(new FileSystemItem("nc", "exe"));
            files.Add(new FileSystemItem("nc", "fil"));
            files.Add(new FileSystemItem("ncpscrip", "hdr"));
            files.Add(new FileSystemItem("nc", "hlp"));
            files.Add(new FileSystemItem("ncff", "hlp"));
            files.Add(new FileSystemItem("telemax", "hlp"));
            files.Add(new FileSystemItem("nc", "ico"));
            files.Add(new FileSystemItem("nc", "ini"));
            files.Add(new FileSystemItem("ncclean", "ini"));
            files.Add(new FileSystemItem("norton", "ini"));
            files.Add(new FileSystemItem("telemax", "ini"));
        }
        override public void Draw(int left, int top, int right, int bottom)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            DrawUtility.PaintBox(left, top, right, bottom);
            DrawUtility.DrawBox(left, top, right, bottom);
            DrawUtility.DrawSeparatorHorizontal(left, bottom - 2, right);
            DrawUtility.DrawSeparatorVertical(left + 13, top, bottom - 2);
            DrawUtility.DrawSeparatorVertical(left + 26, top, bottom - 2);
            Console.SetCursorPosition(right / 2 - 3, top);
            Console.Write(" C:\\NC ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(left + 1, top + 1);
            Console.Write("C:\u2193 Имя");
            Console.SetCursorPosition(left + 14, top + 1);
            Console.Write("    Имя");
            Console.SetCursorPosition(left + 27, top + 1);
            Console.Write("    Имя");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(left + 1, bottom - 1);
            Console.Write("..           \u25BAКАТАЛОГ\u25C4 11.10.02  19:48");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    DrawFile(1 + 13 * i, 3 + j, files[17 * i + j]);
                }
            }
        }

        private void DrawFile(int left, int top, FileSystemItem file)
        {
            string name = file.Name;
            if (name.Length > 11 - file.Type.Length)
            {
                name = name.Substring(0, 7);
                name = name.Insert(7, "~");
            }
            Console.SetCursorPosition(left, top);
            Console.Write(name);
            if (file.Name != "")
            {
                Console.SetCursorPosition(left + 12 - file.Type.Length, top);
                Console.Write(file.Type);
            }
        }
    }
}
