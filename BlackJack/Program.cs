using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    enum Mast { Черви = 0, Крести, Бубны, Пики }
    enum Starshinstvo { двойка = 0, тройка, четверка, пятерка, шестерка, семерка, восьмерка, девятка, десятка, Валет, Дама, Король, Туз }
    class Card
    {
        private int[] ochki = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
        private int k = 0;
        private Mast[] masti = new Mast[52];
        private Starshinstvo[] starsh = new Starshinstvo[52];
        static Random rd = new Random();
        public Card()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = k; j < k + 13; j++)
                {
                    masti[j] = (Mast)i;
                    starsh[j] = (Starshinstvo)(j % 13);
                }
                k += 13;
            }
        }
        //public void Dobor(int podchet, out int pod, out int k)
        //{
        //    if (pod > 16) pod = pod;
        //    else
        //    {

        //    }
        //}
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = masti.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                Mast tmp = masti[j];
                masti[j] = masti[i];
                masti[i] = tmp;
                Starshinstvo temp = starsh[j];
                starsh[j] = starsh[i];
                starsh[i] = temp;
            }
        }
        public void Print()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine($"{starsh[i]} {masti[i]}");
            }
        }
        public Mast this[UInt64 i]
        {
            get
            {
                Mast n = masti[i];
                return n;
            }
        }
        public int this[Int32 i]
        {
            get { return ochki[i]; }
        }
        public Starshinstvo this[Int64 i]
        {
            get { return starsh[i]; }
        }
        public int Dlina
        {
            get { return starsh.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int podschet_ochkovpc = 0;
            int podschet_ochkov = 0;
            bool fl = false;
            int k;
            string str = "да";
            while (str == "да")
            {
                podschet_ochkov = 0;
                podschet_ochkovpc = 0;
                k = 0;
                Card obj1 = new Card();
                obj1.Shuffle();
                Console.WriteLine($"\t\tКарты компьютера");
                for (int i = 0; i < 2; i++)
                {
                    
                    Console.WriteLine($"Карта :{obj1[(Int64)k]} {obj1[(UInt64)k]}");
                    podschet_ochkovpc += obj1[(Int32)((int)obj1[(Int64)k])];
                    if (obj1[(Int64)k] == Starshinstvo.Туз) fl = true;
                    k++;
                }
                if (fl)
                {
                    Console.WriteLine($"У него {podschet_ochkovpc - 10}/{podschet_ochkovpc} очков");
                    fl = false;
                }
                else
                {
                    Console.WriteLine($"У него {podschet_ochkovpc} очков");
                }
                Console.WriteLine($"\t\tТвои карты");
                for (int i = 0; i < 2; i++)
                {
                    
                    Console.WriteLine($"Карта :{obj1[(Int64)k]} {obj1[(UInt64)k]}");
                    podschet_ochkov += obj1[(Int32)((int)obj1[(Int64)k])];
                    if (obj1[(Int64)k] == Starshinstvo.Туз) fl = true;
                    k++;
                }
                if (fl)
                {
                    Console.WriteLine($"У тебя {podschet_ochkov - 10}/{podschet_ochkov} очков");
                }
                else
                {
                    Console.WriteLine($"У тебя {podschet_ochkov} очков");
                }
                Console.WriteLine($"Будешь добирать?");
                if(Console.ReadLine() == "да")
                {
                    Console.WriteLine($"Карта :{obj1[(Int64)k]} {obj1[(UInt64)k]}");
                    podschet_ochkov += obj1[(Int32)((int)obj1[(Int64)k])];
                    if (fl) Console.WriteLine($"У тебя {podschet_ochkov - 10}/{podschet_ochkov} очков");
                    else Console.WriteLine($"У тебя {podschet_ochkov} очков");
                    if (podschet_ochkov > 21) Console.WriteLine($"Перебор!");
                    k++;
                }
                str = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
