using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    class Elethossz
    {
        private int Tol { get; set; }
        private int Ig { get; set; }
        public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

        public bool IsmertAzElethossz => ElethosszEvekben != -1;

        public Elethossz(string SzuletesHalalozas)
        {
            string[] m = SzuletesHalalozas.Split('-');
            try
            {
                Tol = int.Parse(m[0]);
            }
            catch (Exception)
            {
                Tol = -1;
            }
            try
            {
                Ig = int.Parse(m[1]);
            }
            catch (Exception)
            {
                Ig = -1;
            }
        }
    }
    class Dijazott
    {
        public int Ev { get; private set; }
        public string Nev { get; private set; }
        public string SzuletesHalalozas { get; private set; }
        public string Orszagkod { get; private set; }

        public Dijazott(string sor)
        {
            string[] m = sor.Split(';');
            Ev = int.Parse(m[0]);
            Nev = m[1];
            SzuletesHalalozas = m[2];
            Orszagkod = m[3];
        }

        //2. Feladat.
        //!!--nobeldíjak txt beolvasása--!!
        public static List<Dijazott> LoadDB()
        {
            List<Dijazott> list = new List<Dijazott>();

            StreamReader sr = new StreamReader("orvosi_nobeldijak.txt");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                list.Add(new Dijazott(sr.ReadLine()));
            }
            sr.Close();

            return list;
        }

    }

    class OrvosiNobeldijasok
    {


        static void Main()
        {
            List<Dijazott> adatbazis = Dijazott.LoadDB();

            


            //3. Feladat.
            Console.WriteLine($"3.Feladat: Díjazottak száma: {adatbazis.Count} fő");

            //4. Feladat.

            int utolsoEv = adatbazis.First().Ev;
            foreach (var i in adatbazis.Skip(1)) 
            {
                if (i.Ev > utolsoEv) utolsoEv = i.Ev;
            }
            Console.WriteLine($"4. Feladat: Utolsó Év: {utolsoEv}");

            //5. Feladat.
            Console.WriteLine("5. Feladat: Kérem adja meg egy ország kódját: ");
            string inputOrszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> inputOrszagDijazottjai = new List <Dijazott>();
            foreach (var item in adatbazis)
            {
                if (item.Orszagkod == inputOrszagkod) inputOrszagDijazottjai.Add(item);
            }
            if (inputOrszagDijazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");
            }
            if (inputOrszagDijazottjai.Count == 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév {inputOrszagDijazottjai.First().Nev}");
                Console.WriteLine($"\tÉv {inputOrszagDijazottjai.First().Ev}");
                Console.WriteLine($"\tSz/H {inputOrszagDijazottjai.First().SzuletesHalalozas}");
            }
            if (inputOrszagDijazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszagDijazottjai.Count} fő díjazott volt!");
            }


            //6. Feladat
            Console.WriteLine("6.Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in adatbazis)
            {
                if (stat.ContainsKey(i.Orszagkod)) stat[i.Orszagkod]++;
                else stat.Add(i.Orszagkod, 1);
            }
            foreach (var i in stat)
            {
                if (i.Value > 5) Console.WriteLine($"\t{i.Key} -  {i.Value} fő");
            }
                        Console.ReadKey();
        }
    }
 }
