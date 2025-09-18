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
        public DateOnly LastModifiedDate { get; set; }
        public TimeOnly LastModifiedTime { get; set; }

        public FileSystemItem() 
        {
            Name = string.Empty;
            Type = string.Empty;
        }

        public FileSystemItem(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public FileSystemItem(string name, string type, long size, DateOnly lastModifiedDate, TimeOnly lastModifiedTime)
        {
            Name = name;
            Type = type;
            Size = size;
            LastModifiedDate = lastModifiedDate;
            LastModifiedTime = lastModifiedTime;
        }
    }
}
