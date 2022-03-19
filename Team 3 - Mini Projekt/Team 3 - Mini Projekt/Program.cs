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

            
            
            LoadFile loadFile = new LoadFile();
            loadFile.Add(new Foo { ID = 1, Model = "Jacob" });
            Console.WriteLine(loadFile.GetById(1).Model);

            Console.ReadKey();
        }
    }
}
