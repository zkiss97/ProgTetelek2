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
            this.jel = "+";
            this.bennevane = 0;
        }


        public void Hanyadik(int hossz, int[] tomb)
        {
            Console.WriteLine("Kiskacsóddal add meg melyik számot keressük");
            hanyadikvagyok = int.Parse(Console.ReadLine());
            for (int i = 0; i < tomb.Length; i++)
            {
                if (hanyadikvagyok == i)
                {
                    Console.WriteLine("A megadott szám a(z) {0} tömbindexen áll", i);
                    break;
                }
            }
        }

        public void Kicsinagy(int hossz, int[] tomb)
        {
            int[] kicsinagytomb = new int[1];
            for (int i = 0; )
        }

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


    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Courage tomb1 = new Courage();
            int contains;


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
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\nA tömb elemeinek darabszáma: ");
            Console.WriteLine(tomb1.hossz);


            Console.WriteLine("\nCustom érték keresése: ");
            tomb1.Hanyadik(tomb1.hossz, numbers);

            Console.WriteLine("\nTetszőleges érték: ");
            contains = int.Parse(Console.ReadLine());
            tomb1.Bennevane(tomb1.hossz, numbers, contains);

            Console.WriteLine("\nA tömb negatív elemeinek darabszáma: ");
            tomb1.Negativok(tomb1.hossz, numbers);



            Console.ReadLine();
        }
    }
}
