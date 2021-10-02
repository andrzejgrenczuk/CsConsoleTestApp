using System;
using System.Collections.Generic;
//using static System.Array;

namespace CsConsoleTestApp{
    class Tablice{
        public void TabliceJednoWymiarowe(){
        int[] numbers = new int[6] {2, 4, 6, 7, 83, 96};
        string[] cities = new string[3] { "Wroclaw", "London", "Warszawa"};

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[4]);

        foreach(var city in cities)
        {
            Console.WriteLine(city);
        }
        Console.WriteLine("Długość tablicy 'numbers': "+numbers.Length);
        Console.WriteLine("Długość tablicy 'cities': "+cities.Length);
    }
    public void TabliceDwuWymiarowe(){
        int[,] numbersTwo = new int[2,2] {{0, 1}, {2, 3} };
        string[,] citiesTwo = new string[3,2] { {"Wroclaw", "London"}, {"Warszawa", "Poznan"}, {"Katowice", "Krakow"} };
        
        Console.WriteLine(numbersTwo[0,0]);
        Console.WriteLine(numbersTwo[0,1]);
        Console.WriteLine(numbersTwo[1,0]);
        Console.WriteLine(numbersTwo[1,1]);
        foreach(var cityTwo in citiesTwo)
        {
            Console.WriteLine(cityTwo);
        }
        foreach(var numberTwo in numbersTwo)
        {
            Console.WriteLine(numberTwo);
        }
        Console.WriteLine("Długość tablicy 'numbersTwo': "+numbersTwo.Length);
        Console.WriteLine("Długość tablicy 'citiesTwo': "+citiesTwo.Length);
    }
    
    public void TabliceWieloWymiarowe()
    {
        /*int[,,] numbersThree = new[] {
                                        new[] { {{ 0, 1, 2}, { 3, 4, 5}}, 
                                        new[] {{ 6, 7, 8}, { 9, 10, 11}} } };
        string[][] citiesThree = new string[4][] { {"Wroclaw", "London", "Krakow"}, {"Wroclaw", "London", "Krakow"}, {"Warszawa", "Poznan", "Gdansk"}, {"Lublin", "Katowice", "Krakow"} };
        */

        int[,,] numbersThree = new int[4,3,3];
        string[,,] citiesThree = new string[3,3,3];

        numbersThree[0,0,0] = 1;
        numbersThree[0,0,1] = 3;
        numbersThree[0,1,1] = 7;

        citiesThree[0,0,0] = "Wrocław";
        citiesThree[0,0,1] = "Poznań";
        citiesThree[0,1,0] = "Lublin";
        citiesThree[1,1,1] = "Krakow";

        /*Console.WriteLine(numbersThree[0,0,0]);
        Console.WriteLine(numbersThree[0,0,1]);
        Console.WriteLine(numbersThree[0,1,0]);
        Console.WriteLine(numbersThree[1,0,0]);
        Console.WriteLine(citiesThree[0,0,0]);
        Console.WriteLine(citiesThree[0,0,1]);
        Console.WriteLine(citiesThree[0,1,0]);
        Console.WriteLine(citiesThree[1,1,1]); */
        foreach(var cityThree in citiesThree)
        {
            Console.WriteLine(cityThree);
        }
        foreach(var numberThree in numbersThree)
        {
            Console.WriteLine(numbersThree);
        }


        Console.WriteLine("Długość tablicy 'numbersThree': "+numbersThree.Length);
        Console.WriteLine("Długość tablicy 'citiesThree': "+citiesThree.Length);

                // Two-dimensional array.
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // The same array with dimensions specified.
        int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // A similar array with string elements.
        string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                                { "five", "six" } };

        // Three-dimensional array.
        int[,,] numbersFour = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                        { { 7, 8, 9 }, { 10, 11, 12 } } };
        // The same array with dimensions specified.
        int[,,] citiesFour = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                            { { 7, 8, 9 }, { 10, 11, 12 } } };

        // Accessing array elements.
        System.Console.WriteLine(array2D[0, 0]);
        System.Console.WriteLine(array2D[0, 1]);
        System.Console.WriteLine(array2D[1, 0]);
        System.Console.WriteLine(array2D[1, 1]);
        System.Console.WriteLine(array2D[3, 0]);
        System.Console.WriteLine(array2Db[1, 0]);
        System.Console.WriteLine(numbersFour[1, 0, 1]);
        System.Console.WriteLine(citiesFour[1, 1, 2]);

        // Getting the total count of elements or the length of a given dimension.
    }
}
}