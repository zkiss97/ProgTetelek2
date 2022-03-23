using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTetelek2
{
    class Courage
    {
        public int hossz;
        public int[] tomb = new int[10];
        public int hanyadikvagyok;
        public int nagyobbvagye;
        public string relacio;
        public int bennevane;

        public Courage(int hossz, int hanyadikvagyok, int nagyobbvagye, string relacio, int bennevane)
        {
            this.hossz = hossz;
            this.hanyadikvagyok = hanyadikvagyok;
            this.nagyobbvagye = nagyobbvagye;
            this.relacio = relacio;
            this.bennevane = bennevane;
        }
        public Courage()
        {
            this.hossz = 1;
            this.hanyadikvagyok = 0;
            this.nagyobbvagye = 0;
            this.relacio = "";
            this.bennevane = 0;
        }

        /*Kiválasztás metódusa
        Bekér egy számot a felhasználótól és kiírja, hogy ez a szám hányadik helyen szerepel a számok között.*/

        public void Hanyadik(int hossz, int[] tomb)
        {
            bool bennevane = false;
            Console.WriteLine("Add meg melyik számot keressük");
            hanyadikvagyok = int.Parse(Console.ReadLine());
            for (int i = 0; i < tomb.Length; i++)
            {
                if (hanyadikvagyok == tomb[i])
                {
                    Console.WriteLine("A megadott szám a(z) {0} tömbindexen áll", i);
                    bennevane = true;
                    break;
                }
            }
            if (bennevane == false)
            {
                Console.WriteLine("A keresett elem nincs a tömbben");
            }
        }

        /*Kiválogatás metódusa
        Bekér egy számot és egy relációs jelet a felhasználótól és kiírja a relációnak megfelelő tömbelemeket.*/


        public void Kicsinagy(int hossz, int[] tomb) //, int nagyobbvagye, string relacio)
        {
            int[] kicsitomb = new int[hossz];
            int[] nagytomb = new int[hossz];
            bool ervenytelen = false;
            int nagydb = 0;
            int kisdb = 0;
            Console.WriteLine("Add meg a vizsgált értéket: ");
            nagyobbvagye = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a relációt: ");
            relacio = Console.ReadLine();


            if ((relacio != "<") && (relacio != ">"))
            {
                Console.WriteLine("Érvénytelen");
                ervenytelen = true;
            }
            
            if (ervenytelen == false)
            {
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (relacio == "<")
                    {
                        if (tomb[i] < nagyobbvagye)
                            {
                                kisdb++;
                            }
                    }
                    if (relacio == ">")
                    {
                        if (tomb[i] > nagyobbvagye)
                        {
                            nagydb++;
                        }            
                    }
                }
            }
            Console.WriteLine("kisdb = {0} nagydb = {1}", kisdb, nagydb);
            for (int i = 0; i <= kisdb; i++)
            {
                if (tomb[i] < nagyobbvagye)
                {
                    kicsitomb[i] = tomb[i];
                }
            }
            for (int i = 0; i <= nagydb; i++)
            {
                if (tomb[i] > nagyobbvagye)
                {
                    nagytomb[i] = tomb[i];
                }
            }

            Console.WriteLine("A kicsi tömb elemei:");
            for (int i = 0; i < kicsitomb.Length; i++)
            {
                Console.WriteLine(kicsitomb[i]);
            }
            Console.WriteLine("A nagy tömb elemei:");
            for (int i = 0; i < nagytomb.Length; i++)
            {
                Console.WriteLine(nagytomb[i]);
            }

        }
        /*
        public void Bennevane(int hossz, int[] tomb, int bennevane)
        {
            bool tartalmazza = false;
            for (int i = 0; i < hossz; i++)
            {
                if (tomb[i] == bennevane)
                {
                    Console.WriteLine("A megadott szám benne van a tömbben, a(z) {0} indexen", i);
                    tartalmazza = true;
                    break;
                }
            }
            if (tartalmazza == false)
            {
                Console.WriteLine("A megadott szám NINCS benne a tömbben.");
            }
        }
        */

    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Courage tomb1 = new Courage();
            int contains;
            int bigorsmall;
            string jel;


            Console.WriteLine("Add meg, hány eleme van a tömbnek: ");
            tomb1.hossz = int.Parse(Console.ReadLine());
            if (tomb1.hossz > 200)
            {
                tomb1.hossz = rnd.Next(100, 200);
            }
            int[] numbers = new int[tomb1.hossz];

            for (int i = 0; i < tomb1.hossz; i++)
            {
                numbers[i] = rnd.Next(-100, 100);
            }

            Console.WriteLine("\nA tömb elemei: ");
            for (int i = 0; i < tomb1.hossz; i++)
            {
                Console.WriteLine("{0} --> {1}", i, numbers[i]);
            }

            Console.WriteLine("\nA tömb elemeinek darabszáma: ");
            Console.WriteLine(tomb1.hossz);


            Console.WriteLine("\nCustom érték helyének keresése: ");
            tomb1.Hanyadik(tomb1.hossz, numbers);
            
            /*
            Console.WriteLine("\nTetszőleges érték: ");
            contains = int.Parse(Console.ReadLine());
            tomb1.Bennevane(tomb1.hossz, numbers, contains);
            */

            Console.WriteLine("\nA tömb tetszőleges értékétől kisebb és nagyobb számok: ");
            //Console.WriteLine("A vizsgálandó érték: ");
            //bigorsmall = int.Parse(Console.ReadLine());
            //Console.WriteLine("Az összehasonlítás: ");
            //jel = Console.ReadLine();

            tomb1.Kicsinagy(tomb1.hossz, numbers); //, bigorsmall, jel);



            Console.ReadLine();
        }
    }
}

// DDLC Steam