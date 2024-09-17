using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Employers
{
    class Tulajdonsagok
    {
        public int azon;
        public string nev;
        public int kor;
        public int kereset;

        public Tulajdonsagok(string sor)
        {
            string[] darabok = sor.Split(';');
            this.azon = Convert.ToInt32(darabok[0]);
            this.nev = darabok[1];
            this.kor = Convert.ToInt32(darabok[2]);
            this.kereset = Convert.ToInt32(darabok[3]);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tulajdonsagok> tulajdonsag = new List<Tulajdonsagok>();
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");
            while (!sr.EndOfStream)
            {
                tulajdonsag.Add(new Tulajdonsagok(sr.ReadLine()));
            }
            sr.Close();

            //3. feladat
            foreach (var item in tulajdonsag)
            {
                Console.Write(item.nev + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //4. feladat
            int legnagyobb = 0;
            foreach (var item in tulajdonsag)
            {
                if (item.kereset > legnagyobb)
                {
                    legnagyobb = item.kereset;
                }
            }
            Console.WriteLine($"{legnagyobb}");
            Console.WriteLine();

            //5. feladat
            foreach (var item in tulajdonsag)
            {
                if (65 - 10 == item.kor)
                {
                    Console.WriteLine($"{item.nev} {item.kor}");
                }
            }
            Console.WriteLine();

            //6. feladat
            int db = 0;
            foreach (var item in tulajdonsag)
            {
                if (item.kereset >= 50000)
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            Console.ReadLine();
        }
    }
}
