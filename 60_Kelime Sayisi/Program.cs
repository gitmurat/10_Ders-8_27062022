namespace _60_Kelime_Sayisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yazi = "    CSharp     Temel      Konuları    Bitti   ";
            yazi = yazi.Trim();
            int KelimeSayisi = 0;
            if (yazi.Length > 0)
            {
                for (int i = 0; i < yazi.Length; i++)
                {
                    if (yazi[i] == ' ' && yazi[i - 1] != ' ')
                    {
                        KelimeSayisi++;
                    }
                }
                Console.WriteLine(KelimeSayisi+1);
            }
            else
            {
                Console.WriteLine(KelimeSayisi);
            }
        }
    }
}