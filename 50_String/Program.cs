namespace _50_String
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            string yazi = "CSharp Temel Ders";
            int KelimeSayisi = 0;
            Console.WriteLine(yazi);
            Console.WriteLine("------------------");
            Console.WriteLine(yazi.IndexOf(" "));
            Console.WriteLine(yazi.Length);                 //string aslında bir char array'dir o yüzden length hiçbir değişiklik olmadan array'de çalıştğı gibi çalışır
            Console.WriteLine("------------------");

            /*for (int i = 0; i < yazi.Length; i++)
            {
                Console.WriteLine(yazi[i]);
            }*/

            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] == ' ')
                {
                    KelimeSayisi++;
                }
            }
            Console.WriteLine(KelimeSayisi+1);
        }
    }
}