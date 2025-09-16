namespace FileManagerInterfaceMockup
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<FileSystemItem> files = new List<FileSystemItem>();
            //files.GetFiles();

            FileManager fileManager = new FileManager(files);
            fileManager.DrawUI();

            Console.ReadKey();
        }
    }
}
