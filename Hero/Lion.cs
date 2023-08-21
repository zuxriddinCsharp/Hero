using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    internal class Lion : Hero
    {
        public int NormalHealth { get; set; }
        public Lion(string name, int attackStrength, double speed, int health, int normalHealth)
            : base(name, attackStrength, speed, health)
        {
            NormalHealth = normalHealth;
        }
        public override void Run()
        {
            if (Health < NormalHealth)
            {
                double ChangetSpeed = Speed * 0.6;
                Console.WriteLine($"{Name} is running at speed {ChangetSpeed}");
            }
        }
    }
}
