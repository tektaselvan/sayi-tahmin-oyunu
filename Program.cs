using System;

namespace sayi_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayı tahmin 
            // 1-100 arasında rastgele sayı buldurun.
            // Puanlama yapınız.
            // Devam etmek istiyorsa ve istemiyorsa e/h


            do
            {
                int tutulan = (new Random()).Next(1, 100);
                int hak = 5;
                int sayi;
                int tur = 00;
                double sorupuani = 100 / hak;


                while (hak > 0)
                {
                    tur++;
                    Console.Write($"{tur}. sayı: ");
                    sayi = int.Parse(Console.ReadLine());
                    hak--;
                    if (sayi == tutulan)
                    {
                        double puan = 100 - (sorupuani * (tur - 1));
                        Console.WriteLine($"Tebrikler {tur} Defada Bildiniz!");
                        Console.WriteLine($"Toplam puan: {puan}");
                        break;
                    }
                    else
                    {
                        if (hak == 0)
                            break;
                        if (tutulan > sayi)
                            Console.WriteLine("Yukarı");
                        else
                            Console.WriteLine("Aşağı");
                    }




                }
                Console.WriteLine("Oyun Bitti!");
                Console.Write("Devam Etmek istiyor musunuz? e/h: ");
                string result = Console.ReadLine();
                if (result == "h" || result == "hayır" || result == "Hayır")
                    break;

            } while (true);
        }
    }
}
