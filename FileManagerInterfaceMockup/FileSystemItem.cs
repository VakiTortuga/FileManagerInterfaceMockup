using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerInterfaceMockup
{
    internal class FileSystemItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public DateTime LastModified { get; set; }

        public FileSystemItem() 
        {
            Name = string.Empty;
            Type = string.Empty;
        }
    }
}
