using Enums_Collections.Helpers.Enums;
using System;
using System.Collections.Generic;

namespace Enums_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Silah Yaratmaq");
            Console.WriteLine("2. Atdış etmek");
            Console.WriteLine("3. Növbeti gülleni yoxlamaq");
            Console.WriteLine("4. Silahı doldurmaq");
            Console.WriteLine("5. Çıxış");

            Weapon silah = null;

            while (true)
            {
                Console.Write("Seçiminizi daxil edin: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Mermi Növü seçin (MM_5_45=0, MM_7_47=1, MM_10_45=2): ");
                        BulletType mermiNovu = (BulletType)Enum.Parse(typeof(BulletType), Console.ReadLine());
                        Console.Write("Gülle sayını daxil edin: ");
                        int gulleSayi = int.Parse(Console.ReadLine());
                        silah = new Weapon(mermiNovu, gulleSayi);
                        Console.WriteLine("Silah yaradıldı!");
                        break;
                    case "2":
                        if (silah != null)
                        {
                            silah.Fire();
                        }
                        else
                        {
                            Console.WriteLine("evvelce silah yaratmalısınız.");
                        }
                        break;
                    case "3":
                        if (silah != null)
                        {
                            silah.PullTrigger();
                        }
                        else
                        {
                            Console.WriteLine("evvelce silah yaratmalısınız.");
                        }
                        break;
                    case "4":
                        if (silah != null)
                        {
                            List<Bullet> yeniGulleler = new List<Bullet>();
                            for (int i = 0; i < silah.MermiSayi; i++)
                            {
                                yeniGulleler.Add(new Bullet(silah.MermiNovleri));
                            }
                            silah.Fill(yeniGulleler);
                            Console.WriteLine("Silah dolduruldu!");
                        }
                        else
                        {
                            Console.WriteLine("evvelce silah yaratmalısınız.");
                        }
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim. Yeniden cehd edin.");
                        break;
                }
            }
        }
    }
}
