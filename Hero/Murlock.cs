using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    internal class Murlock : Hero
    {
        public int NightAttack { get; set; }
        public int NightSpeed { get; set; }
        public Murlock(string name, int attackStrength, double speed, int health, int nightAttack, int nightSpeed)
            : base(name, attackStrength, speed, health)
        {
            NightAttack = nightAttack;
            NightSpeed = nightSpeed;
        }
        public override void Attack()
        {
            if (DateTime.Now.Hour > 21 || DateTime.Now.Hour < 5)
            {
                Console.WriteLine($"{Name} Attacking with strength {NightAttack}");
            }
            else
            {
                Console.WriteLine($"{Name}  Attacking with strength {AttackStrength}");
            }
        }
        public override void Run()
        {
            if (DateTime.Now.Hour > 21 || DateTime.Now.Hour < 5)
            {
                Console.WriteLine($" {Name} running at speed {NightSpeed} ");
            }
            else
            {
                Console.WriteLine($"{Name} running at speed {Speed}");
            }
        }
    }
}
