namespace _10_Ders_8_27062022_Tip_Dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int sayi = 5;
            bool AcilMi = false;
            string girilen;
            Console.WriteLine(sayi + 1);
            Console.WriteLine(sayi + " sayısı");  //buradaki sayı aslında sayi.ToString()

            girilen = Console.ReadLine();
            sayi = int.Parse(girilen);

            Console.WriteLine("---------------------------");
            Console.WriteLine(sayi);*/


            string girilen;
            girilen = Console.ReadLine();
            //int sonuc = 0;
            bool isCorrect = int.TryParse(girilen, out int sonuc);  //tryparse hem bool değer gönderiyor, hem de eğer try çalıştıysa parse ettiği string'i sonuca yazar)

            if (isCorrect)
            {
                Console.WriteLine("Girilen sayı = " + sonuc);
            }
            else
            {
                Console.WriteLine("yanlış giriş");
            }
        }
    }
}