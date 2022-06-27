namespace _80_OrtalamaBul
{
    internal class Program
    {
        static bool OgrenciDurum(int[] sayilar, out int ortalama)
        {
            int toplam = 0;
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            ortalama = toplam / sayilar.Length;
            return (ortalama >= 50);
            
        }
        
        static void Main(string[] args)
        {
            int[] Notlar = { 20, 50, 90 };
            if (OgrenciDurum(Notlar, out int ortalamaNot))
                Console.WriteLine("Geçti");
            else
                Console.WriteLine("Kaldı");

            Console.WriteLine("Ortalama: " + ortalamaNot);
        }
    }
}