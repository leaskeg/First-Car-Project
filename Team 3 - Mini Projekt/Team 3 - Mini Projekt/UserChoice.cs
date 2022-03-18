using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3___Mini_Projekt
{
    internal class UserChoice
    {

        public static void printText()
        {
            Console.WriteLine("Vælg den bil du gerne vil have ud fra nummer");

            Console.WriteLine();
            Console.WriteLine("Biler");
            Console.WriteLine();
            Console.WriteLine("1. Tilføj en bil");
            Console.WriteLine("2. Vis alle biler");
            Console.WriteLine("0. Afslut");
            Console.WriteLine("Angiv dit valg: ");

            Console.WriteLine(LoadFile.listNumber);
        }

        public static void UserInput()
        {
            int typeNumber = 0;

          
        } 
    }
}
