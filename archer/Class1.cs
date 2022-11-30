using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archer
{
    class Archer
    {
        private string Name;
        private int shots;
        private int totalAtack;
        private int defence;
        private int totallife = 100;
        private int life;
        public Archer(string name, int shots)
        {
            Name = name;
            life = totallife;
            this.shots = Math.Abs(shots);
            totalAtack = 10;
            defence = 0;
        }
        public string LifePercent
        {
            get { return $"{life / totallife * 100}"; }
            set { life = int.Parse(value); }
        }
        public string Attack { get { return $"{totalAtack}"; } set { totalAtack = int.Parse(value); } }
        public bool Alive
        { 
            get
            { 
                if (life <= 0)
                { 
                    return false; 
                }
                return true;
            }
        }
        private void Damaged(int atack)
        {
            this.life -= atack;
            if (Alive)
            {
                Console.WriteLine("Он жив");
            }
            else
            {
                Console.WriteLine("Мертв");
            }
        }
        public void shot(string name)
        {
            if (this.shots <= 0)
            {
                Console.WriteLine("Неи стрел");
            }
            else
            {
                Console.WriteLine($"Игрок {this.Name} атаковал игрока {name}, урон: {this.totalAtack}");
            }
        }
    }
}
