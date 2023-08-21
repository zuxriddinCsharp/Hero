using System.Threading.Channels;

namespace Hero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Hero", 50, 70, 100);

            hero.Attack();
            hero.Run();
            hero.Defend();
            hero.Display();

            Console.WriteLine();

            Murlock murlock = new Murlock("Murlock", 10, 20, 100, 15, 25);
            murlock.Display();
            murlock.Attack();
            murlock.Run();

            Console.WriteLine();

            Lion lion = new Lion("Lion", 20, 90, 99, 100);
            lion.Display();
            lion.Run();
        }
    }

}