using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Флеш
{
    enum Mast {Черви = 0, Крести, Бубны, Пики }
    enum Starshinstvo { двойка = 0, тройка, четверка, пятерка, шестерка, семерка, восьмерка, девятка, десятка, Валет, Дама, Король, Туз }
    class Card
    {
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
            bool fl = true;
            string str = "да";
            while (str == "да")
            {
                int k = 0, l;
                l = 1;
                int ch = 0;
                Random rand = new Random();
                Mast[] player_mast = new Mast[52];
                Starshinstvo[] player_starsh = new Starshinstvo[52];
                Card obj1 = new Card();
                obj1.Shuffle();
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Карты {i} раздачи");
                    for (int j = 1; j <= 5; j++)
                    {

                        Console.WriteLine($"{j} карта: {obj1[(Int64)k]} масти {obj1[(UInt64)k]}");
                        player_mast[j - 1] = obj1[(UInt64)k];
                        k++;
                        Thread.Sleep(500);
                    }
                    if (player_mast[0] == player_mast[1] && player_mast[1] == player_mast[2] && player_mast[2] == player_mast[3] && player_mast[3] == player_mast[4])
                    {
                        Console.WriteLine($"{player_mast[0]} флеш у игрока {i}");
                        fl = false;
                        break;
                    }
                    Thread.Sleep(1000);

                }
                if (fl == false) break;
                Console.WriteLine("Карты кончились, флеш не случился");
                Console.WriteLine("Хочешь еще сыграть?");
                str = Console.ReadLine();
            }
            
            Console.ReadLine();
        }
    }
}
