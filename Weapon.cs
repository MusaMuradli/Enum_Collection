using Enums_Collections.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Collections
{
    public class Weapon
    {
        private static int _id = 0;
        public int Id { get; }
        public BulletType MermiNovleri { get; set; }
        public int MermiSayi { get; set; }

        private Stack<Bullet> Bullets = new Stack<Bullet>();

        public Weapon(BulletType mermiNovu, int mermiSayi)
        {
            MermiNovleri = mermiNovu;
            Id = ++_id;
            MermiSayi= mermiSayi;

            for (int i = 0; i < mermiSayi; i++)
            {
                Bullet bullet = new Bullet(mermiNovu);
                Bullets.Push(bullet);

            }
        

        }
        public void Fill(List<Bullet> bulletCollection)
        {
            Bullets.Clear();

            foreach (var bullet in bulletCollection)
            {
                if (Bullets.Count < MermiSayi)
                {
                    Bullets.Push(bullet);
                }
            }
        }
        public void Fire()
        {
            if (Bullets.Count > 0)
            {
                Bullet gulle = Bullets.Pop();
                Console.WriteLine($"Mermi Növü: {gulle.Type}, Qalan ğülle sayı: {Bullets.Count}");
            }
            else
            {
                Console.WriteLine("Gulle bitdi, daban 52.");
            }
        }
        public void PullTrigger()
        {
            if (Bullets.Count > 0)
            {
                Bullet nextMermi = Bullets.Peek();
                Console.WriteLine($"Type: {nextMermi.Type}");
            }
            else
            {
                Console.WriteLine("Mermi yoxdu.");
            }
        }
    }
}
