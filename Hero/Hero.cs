using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    internal class Hero
    {
        public string Name { get; set; }
        public int AttackStrength { get; set; }
        public double Speed { get; set; }
        public int Health { get; set; }
        public Hero(string name, int attackStrength, double speed, int health)
        {
            Name = name;
            AttackStrength = attackStrength;
            Speed = speed;
            Health = health;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} Attacking with strength {AttackStrength}");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} is defending");
        }
        public virtual void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"AtackStrength: {AttackStrength}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Health: {Health}");
        }
    }
}
