using System;

namespace Team_3___Mini_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til mini projekt.");
            LoadFile.loadCarIntoList();
            //Console.WriteLine(textOut);
            UserChoice.printText();
            UserChoice.UserInput();
            //eeakeakeka

            Console.ReadKey();
        }
    }
}
