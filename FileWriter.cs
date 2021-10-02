using System;
using System.IO;
using System.Text;

namespace CsConsoleTestApp
{
    public class FileWriter
    {
        string fileName, linia;
        public void createSaveFile()
        {
            Console.WriteLine("Podaj nazwę pliku do zapisu: ");
            fileName = Console.ReadLine();
            DirectoryInfo katalog = new DirectoryInfo(@"dane\");
            Console.WriteLine("Aktualna ścieżka to: " + katalog.FullName);
            string plik = katalog + fileName;
            try
            {
                Console.WriteLine("Wpisz tekst, który ma zostać zapisany w pliku");
                string tekst = Console.ReadLine();
                string[] lines = { "First line", "Second line", "Third line" };
                using (FileStream fs = File.Create(plik))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(tekst);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nie można utworzyć pliku {0}, ponieważ: {1}", fileName, ex);
            }
        }
        
    }
}