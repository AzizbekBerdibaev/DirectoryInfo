using System.Security.AccessControl;

namespace DirectoryInfo_Homework
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string path = @"C:\\";
            do
            {
                Console.Clear();
                Console.WriteLine(path);
                Console.WriteLine();

                Console.WriteLine($"{"File/Folder", -70}  Size");

                var directoryInfo = new DirectoryInfo(path);
                foreach(var directory in directoryInfo.GetDirectories())
                {
                    Console.WriteLine($".. {directory.Name, -70}");
                }

                foreach(var file in directoryInfo.GetFiles())
                {
                    var fileInfo = file.Name.Length > 50 ? $"{file.Name[47..]}" : file.Name;
                    Console.WriteLine($"{file.Name, -70} {file.Length} bytes");
                }

                Console.WriteLine("Enter folder name to continue: ");

                var input = Console.ReadLine();
                if(!Directory.Exists(input))
                {
                    Console.WriteLine("Fayl topilmadi");
                    break;
                }


            } while (true);
            
               
            Console.ReadLine();
           
        }
    }
}
