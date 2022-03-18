using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3___Mini_Projekt
{
    internal class LoadFile
    {
        //+load_file void()

        public static int listNumber { get; set; }

        public static void loadCarIntoList()
        {
            var txt1 = File.ReadAllLines(@"C:\cars.txt");

            List<string> list = new List<string>(txt1);
            
            //Console.WriteLine(list[0]);
            listNumber = list.Count;
            //Console.WriteLine(list.Count);




            //var logFile = File.ReadAllLines(LOG_PATH);
            //var logList = new List<string>(logFile);
            Console.WriteLine("Hvad skriver den her ? ");
            int test1 = list[1].IndexOf(",");
            Console.WriteLine(test1);
            test1 = list[0].IndexOf(",",list[0].IndexOf(",")+1);
            Console.WriteLine(test1);
            
            for (int i = 0; i < listNumber; i++)
            {
                int zeroComma = 0;
                int firstComma = list[i].IndexOf(",");
                int secoundComma = list[0].IndexOf(",", list[0].IndexOf(",") + 1);

                int gotID = int.Parse(list[i].Substring(zeroComma, firstComma));
                List<Cars.carStruct> carobject1 = new List<Cars.carStruct>();
                
                Cars.carStruct carobject = new Cars.carStruct();

                //carobject1.Add(carobject);
                carobject1.Add(carobject);

                carobject.ID = gotID;
                
                //(text1.IndexOf('J'));
                

                carobject.Model = "testModel";
                carobject.NumberPlate = "DG34288";
                carobject.Price = 344222.22;
                carobject.Year = 1993;

                Console.WriteLine("Hvad er ID?");
                Console.WriteLine(gotID);


            }
            

            // Console.WriteLine(car1.Model);
            // List<string> listCarStructs = new List<string>();

        }

    }
}
