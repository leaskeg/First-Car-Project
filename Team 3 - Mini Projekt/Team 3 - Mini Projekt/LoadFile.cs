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

            
            //Opret liste til bil objekter ud fra listen
            List<Cars.carStruct> carobjectList = new List<Cars.carStruct>();

            for (int i = 0; i < listNumber; i++)
            {
                int stringLength = list[i].Length;
                int zeroComma = 0;
                int firstComma = list[i].IndexOf(",");
                int secoundComma = list[i].IndexOf(",", firstComma+1);
                int thirdComma = list[i].IndexOf(",", secoundComma+1);
                int forthComma = list[i].IndexOf(",", thirdComma + 1);
                //Til at teste hvad der er i variablerne
                Console.WriteLine("hvad står der i list nummer [{1}] : [{0}]",list[i],i);
                Console.WriteLine("Hvar er der i variablerne: \n stringLength={5} og zeroComma={0} og firstComma={1} og secoundComma={2} og thirdComma={3} og forthComma={4}", zeroComma,firstComma,secoundComma,thirdComma,forthComma,stringLength);
                int calc = stringLength - thirdComma;
                Console.WriteLine("Hvad er stringlængden{0} og hvad er stringlængden minus third{1}",stringLength,(stringLength - thirdComma));
                Console.WriteLine("Hvad er stringlængden{0} og hvad er stringlængden minus forth{1}", stringLength, (stringLength - forthComma));

                int gotID = int.Parse(list[i].Substring(zeroComma, firstComma));
                string gotMODEL = list[i].Substring(firstComma+1, secoundComma-2);
                string gotNUMBERPLATE = list[i].Substring(secoundComma+1, stringLength - forthComma);
                string gotYEAR = list[i].Substring(thirdComma + 1, 4);


                Cars.carStruct carobject = new Cars.carStruct();

                carobject.ID = gotID;
                carobject.Model = gotMODEL;
                carobject.NumberPlate = gotNUMBERPLATE;
                carobject.Year = int.Parse(gotYEAR);
                carobject.Price = 344222.22;

                Console.WriteLine("Hvad er ID?");
                Console.WriteLine(gotID);

                carobjectList.Add(carobject);              

            }
            Console.WriteLine("Hvad indeholder carobjectlist:");
            Console.WriteLine(carobjectList.Count);
            for (int i = 0;i < carobjectList.Count; i++)
            {
                Console.WriteLine("ID: [{0}] , ",carobjectList[i].ID,carobjectList[i].Model,carobjectList[i].NumberPlate,carobjectList[i].Year);
            }

            // Console.WriteLine(car1.Model);
            // List<string> listCarStructs = new List<string>();

        }

    }
}
