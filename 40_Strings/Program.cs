namespace _40_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = ("        C# .Net Language       ");
            Console.WriteLine(str);
            Console.WriteLine("+++++++++++++");
            Console.WriteLine("." + str.TrimEnd() + ".");
            Console.WriteLine("." + str.TrimStart() + ".");
            Console.WriteLine("." + str.Trim() + ".");

            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Trim().Length);

            Console.WriteLine(str);
            Console.WriteLine(str.Replace(" ", "_"));
            Console.WriteLine(str.Replace("C#", "VBasic"));   //case sensitive olarak ilk metni ikinci metin ile değiştirir

            Console.WriteLine(str.IndexOf("."));             //verilen string içinde verdiğimiz parametrenin kaçıncı karakterde bulunduğunu gösterir
            Console.WriteLine(str.IndexOf("Net"));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(str.Substring(8,3));          //string içinde 8. karakterden sonra 3 karakter al
            Console.WriteLine("-------------------------------");
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper().Trim());
        }
    }
}