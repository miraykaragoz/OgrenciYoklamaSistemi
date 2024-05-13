using System;

namespace OgrenciYoklamaSistemi
{
    internal class Program
    {
        static List<string> ogrenciler = new List<string>()
        {
            "Solin",
            "Miray",
            "Orhan"
        };
        static List<string> yoklama = new List<string>();

        static void MenuyeDon()
        {           
            Console.WriteLine("\nMenüye dönmek için herhangi bir tuşa basınız.");
            Console.ReadKey(true);
            Menu();
        }

        static void Menu(bool ilkAcilisMi = false)
        {
            Console.Clear();

            if (ilkAcilisMi)
            {
                Console.WriteLine("Hoş Geldiniz!");
            }
            Console.WriteLine("Yapılacak İşlemi Seçin");
            Console.WriteLine("1. Öğrenci Listele");
            Console.WriteLine("2. Yoklama Listele");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminiz: ");
            int inputSecim = int.Parse(Console.ReadLine());

            if (inputSecim == 1)
            {
                Yoklama();
            }
            else if (inputSecim == 2)
            {
                Console.Clear();

                foreach (var ogrenci in ogrenciler)
                {

                        Console.WriteLine($"{ogrenci} Var mı? (Var/Yok)");
                        string inputYoklama = Console.ReadLine();

                        if (inputYoklama == "Var" || inputYoklama == "var")
                        {
                            Console.WriteLine($"{ogrenci} Burada");
                            yoklama.Add($"{ogrenci} Var");
                        }
                        else if (inputYoklama == "Yok" || inputYoklama == "yok")
                        {
                            Console.WriteLine($"{ogrenci} Burada değil");
                            yoklama.Add($"{ogrenci} Yok");
                        }                   
                }

                MenuyeDon(); 
                Menu();
            }
            else if (inputSecim == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Çıkış yapılıyor...");
                Console.ResetColor();
                Environment.Exit(0);
                MenuyeDon();
            }
        }

        static void Yoklama()
        {
            Console.Clear();

            if (yoklama.Count == 0)
            {
                Console.WriteLine("Kayıt Bulunamadı!");
            }

            for (int i = 0; i < yoklama.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {yoklama[i]}");
            }

            MenuyeDon();
        }

        static void Main(string[] args)
        {
            Menu(true);
        }
    }
}
