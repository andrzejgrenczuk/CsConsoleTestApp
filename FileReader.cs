using System;
using System.IO;
using System.Text;

namespace CsConsoleTestApp
{
    public class FileReader
    {
        public void readFile()
        {
    
            Console.WriteLine("Podaj nazwę pliku, który chcesz otworzyć znajdujący w się w katalogu 'dane'");
            string fileName = Console.ReadLine();
            string linia;
            try{
            StreamReader sr = new StreamReader("dane\\"+fileName);
            while ((linia = sr.ReadLine()) != null){
                Console.WriteLine(linia);
            }
            sr.Close();
            }catch(Exception){
                System.Console.WriteLine("Plik {0}, nie został odnaleziony", fileName);
                return;
            }
        }   
        public void readTyping(){
            Console.ReadLine();
        }
    }
}