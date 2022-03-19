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
        
        private List<Foo> carObjectList = new List<Foo>();

        public void Add(Foo foo)
        {
            this.carObjectList.Add(foo);
        }

        public Foo GetById(int id)
        {
            return this.carObjectList.FirstOrDefault(z => z.ID == id);
        }

        public static void loadCarIntoList2()
        {
            //Aflæs hvad der er i filen og lig det i variablen txt1
            var txt1 = File.ReadAllLines(@"C:\car\cars.txt");
            //Opret list, og smid indholdet fra txt1 i den
            List<string> list = new List<string>(txt1);

            //Hvor mange emner er der i list, og overfør det til listNumber 
            listNumber = list.Count; //Console.WriteLine(list.Count);




            for (int i = 0; i < listNumber; i++)
            {
                int stringLength = list[i].Length; // hvor lang er hele linjen i [i]
                int zeroComma = 0; //første tegn i en linje er ved plads 0
                int firstComma = list[i].IndexOf(","); //hvor første komma er
                int secoundComma = list[i].IndexOf(",", firstComma + 1); // hvor andet komma er
                int thirdComma = list[i].IndexOf(",", secoundComma + 1); // hvor tredje komma er 
                int forthComma = list[i].IndexOf(",", thirdComma + 1); // hvor fjere komma er

                //Til at teste hvad der er i variablerne
                //Console.WriteLine("hvad står der i list nummer [{1}] : [{0}]",list[i],i);
                //Console.WriteLine("Hvar er der i variablerne: \n stringLength={5} og zeroComma={0} og firstComma={1} og secoundComma={2} og thirdComma={3} og forthComma={4}", zeroComma,firstComma,secoundComma,thirdComma,forthComma,stringLength);


                int gotID = int.Parse(list[i].Substring(zeroComma, firstComma)); //Substring(fra, hvorLangtFrem) // hent ID ud fra linjen
                string gotMODEL = list[i].Substring(firstComma + 1, (secoundComma - firstComma) - 1); // hent model ud fra linjen
                string gotNUMBERPLATE = list[i].Substring(secoundComma + 1, (thirdComma - secoundComma) - 1); // hent nummerplade ud fra linjen
                string gotYEAR = list[i].Substring(thirdComma + 1, (forthComma - thirdComma) - 1); // hent år ud fra linjen
                string gotPRICE = list[i].Substring(forthComma + 1, (stringLength - forthComma) - 1); // hent pris ud fra linjen


                Cars.carStruct carobject = new Cars.carStruct(); // opret nyt bil objekt

                carobject.ID = gotID; // tilføj ID til bilobjekt
                carobject.Model = gotMODEL; // tilføj model til bilobjekt
                carobject.NumberPlate = gotNUMBERPLATE; // tilføj nummerplade til bilobjekt
                carobject.Year = int.Parse(gotYEAR); // tilføj år til bilobjekt
                carobject.Price = double.Parse(gotPRICE); // tilføj pris til bilobjekt

                Foo.carObjectList.Add(carobject); // flyt bil objekt over i bilobjekt listen



            }
        }



        public static int listNumber { get; set; }

        public static void loadCarIntoList()
        {
            //Aflæs hvad der er i filen og lig det i variablen txt1
            var txt1 = File.ReadAllLines(@"C:\car\cars.txt");
            //Opret list, og smid indholdet fra txt1 i den
            List<string> list = new List<string>(txt1);
            
            //Hvor mange emner er der i list, og overfør det til listNumber 
            listNumber = list.Count; //Console.WriteLine(list.Count);




            
            //Opret liste til bil objekter ud fra listen
            List<Cars.carStruct> carobjectList = new List<Cars.carStruct>();






            //opret nye biler ud fra listen, og overføre dem til carobjectList
            for (int i = 0; i < listNumber; i++)
            {
                int stringLength = list[i].Length; // hvor lang er hele linjen i [i]
                int zeroComma = 0; //første tegn i en linje er ved plads 0
                int firstComma = list[i].IndexOf(","); //hvor første komma er
                int secoundComma = list[i].IndexOf(",", firstComma+1); // hvor andet komma er
                int thirdComma = list[i].IndexOf(",", secoundComma+1); // hvor tredje komma er 
                int forthComma = list[i].IndexOf(",", thirdComma + 1); // hvor fjere komma er

                //Til at teste hvad der er i variablerne
                //Console.WriteLine("hvad står der i list nummer [{1}] : [{0}]",list[i],i);
                //Console.WriteLine("Hvar er der i variablerne: \n stringLength={5} og zeroComma={0} og firstComma={1} og secoundComma={2} og thirdComma={3} og forthComma={4}", zeroComma,firstComma,secoundComma,thirdComma,forthComma,stringLength);


                int gotID = int.Parse(list[i].Substring(zeroComma, firstComma)); //Substring(fra, hvorLangtFrem) // hent ID ud fra linjen
                string gotMODEL = list[i].Substring(firstComma+1, (secoundComma-firstComma)-1); // hent model ud fra linjen
                string gotNUMBERPLATE = list[i].Substring(secoundComma+1, (thirdComma - secoundComma)-1); // hent nummerplade ud fra linjen
                string gotYEAR = list[i].Substring(thirdComma + 1, (forthComma - thirdComma)-1); // hent år ud fra linjen
                string gotPRICE = list[i].Substring(forthComma + 1, (stringLength-forthComma)-1); // hent pris ud fra linjen


                Cars.carStruct carobject = new Cars.carStruct(); // opret nyt bil objekt

                carobject.ID = gotID; // tilføj ID til bilobjekt
                carobject.Model = gotMODEL; // tilføj model til bilobjekt
                carobject.NumberPlate = gotNUMBERPLATE; // tilføj nummerplade til bilobjekt
                carobject.Year = int.Parse(gotYEAR); // tilføj år til bilobjekt
                carobject.Price = double.Parse(gotPRICE); // tilføj pris til bilobjekt

                carobjectList.Add(carobject); // flyt bil objekt over i bilobjekt listen      

            }
            

        }





    }
}
