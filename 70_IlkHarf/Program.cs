namespace _70_IlkHarf
{
    internal class Program
    {
        static string IlkHarfiBuyuk (string yazi)
        {
            string sonuc = "";
            for (int i = 0; i<yazi.Length; i++)
            {
                char ch;
                if (i==0 || (yazi[i] != ' ' && yazi[i-1] == ' '))   //veya operatöründe ilk şart gerçekleşirse diğer şartlara bakılmaz
                    ch = yazi[i].ToString().ToUpper()[0];
                else
                    ch = yazi[i].ToString().ToLower()[0];
                sonuc = sonuc + ch;
            }

            return sonuc;
        }
        static void Main(string[] args)
        {
            string yazi = "HAFtaya bayraM TATILI";
            Console.WriteLine(IlkHarfiBuyuk(yazi));
        }
    }
}