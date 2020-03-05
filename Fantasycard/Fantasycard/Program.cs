using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasycard
{
    class Program
    {
        public static List<Card> kartyak;
        private static void Beolvas(string fajlnev)
        {
            kartyak = new List<Card>();
            using(var sr = new StreamReader(fajlnev))
            {
                //Fejléc kihagyása
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    //Sor beolvasás és split
                    string[] sor = sr.ReadLine().Split(';');
                    int power = Convert.ToInt32(sor[0]);
                    string name = sor[1];
                    string faction = sor[2];
                    string race = sor[3];
                    string class_ = sor[4];
                    var kartya = new Card(power, name, faction, race, class_);
                    kartyak.Add(kartya);

                }
                sr.Close();
                //BeolvasasDebug();
            }
        }
        private static void Harmadik()
        {
            foreach (var kartya in kartyak)
            {
                if (kartya.Name == "Leeroy")
                {
                    Console.WriteLine("A Leeroy nevű kártya a " + kartya.Race + " fajba tartozik.");
                }
            }
        }
        private static void Negyedik()
        {
           
        }
        private static void BeolvasasDebug()
        {
            for (int i = 0; i < kartyak.Count; i++)
            {
                Console.Write(i + " ");
                Console.WriteLine(kartyak[i]);
            }
        }

        static void Main(string[] args)
        {
            Beolvas("fantasycard.csv");
            Harmadik();



            Console.ReadLine();

        }
    }
}
