namespace FileManagerInterfaceMockup
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<FileSystemItem> files = new List<FileSystemItem>();
            //files.GetFiles(); если реализовывать функцию, то нужна и дальнейшая передача в элементах интерфейса

            FileManager fileManager = new FileManager(files);
            fileManager.DrawFileManager();

            Console.ReadKey();
        }
    }
}
