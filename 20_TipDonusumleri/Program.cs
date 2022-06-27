namespace _20_TipDonusumleri
{
    internal class Program
    {
        static bool PozitifMi (string girilen, out int sayi)
        {
            sayi = int.Parse(girilen);

            if (sayi > 0)
                return true;
            else
                return false;
        }
        
        static void Main(string[] args)
        {
            string girilensayi = "5";

            bool Pozitif = PozitifMi(girilensayi, out int sayi);
            Console.WriteLine(Pozitif);
            Console.WriteLine(sayi);
        }
    }
}