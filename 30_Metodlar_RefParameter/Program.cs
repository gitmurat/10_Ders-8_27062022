namespace _30_Metodlar_RefParameter
{
    internal class Program
    {
        static void Swap (ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            sayi1 = 5; sayi2 = 0;
            

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            Swap(ref sayi1, ref sayi2);

            Console.WriteLine("-------------------");
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
        }
    }
}