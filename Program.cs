using System;
//using InnyProgram;

namespace CsConsoleTestApp
{
    public class Program
    {
        public void printText()
        {
            Console.WriteLine("Blah, blah, blah");
        }
        static void Main(string[] args)
        {
            string odpowiedz;

            Console.WriteLine("============================================================\n"
            + "Projekt tworzony w ramach samodzielnej nauki\n"
            + "Autorzy: Michał Bruder, Andrzej Greńczuk\n"
            + "============================================================\n");
            Console.WriteLine("Wybierz następującą opcję: \n"
            +""
            );
            var opcja = Console.ReadLine();
            switch (opcja)
            {
                case :
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Pusta linia");
                    break;
            }

            Program p = new Program();  //żeby móc wywoływać inne metody w ramach klasy, które nie są opisane w Main()
            InnyProgram ip = new InnyProgram();
            Random rand = new Random();
            Tablice t = new Tablice();
            Listy l = new Listy();
            FileReader fr = new FileReader();
            FileWriter fw = new FileWriter();

            int randomNumber = rand.Next(0, 100);

            Console.WriteLine(randomNumber);
            Console.WriteLine("Hello World!");
            Console.Write("Ja się masz? ");
            odpowiedz = Console.ReadLine();
            Console.WriteLine("Czujesz sie, " + odpowiedz);
            p.printText();
            ip.cos();
            ip.ktorys();
            Console.WriteLine("Tablica jednowymiarowa");
            t.TabliceJednoWymiarowe();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Tablica dwuwymiarowa");
            t.TabliceDwuWymiarowe();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Tablice wielowymiarowe");
            t.TabliceWieloWymiarowe();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            l.run();
            fr.readFile();
            fw.createSaveFile();

            Console.Write("Wybierz opcje: ");
            var y = Console.ReadLine();
            //var y = t.TabliceWieloWymiarowe().numbersThree;
            switch (y)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Pusta linia");
                    break;
            }

            //przed zakończeniem programu
            Console.WriteLine("Kończymy zabawę!\n"
            + "Naciśnij dowolny klawisz, by zakończyć!");
            Console.ReadKey();
        }
    }
}
