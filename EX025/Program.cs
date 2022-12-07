internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Определение степение числа");
        Console.Write("Введите число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень: ");
        var B = Convert.ToInt32(Console.ReadLine());
        int result = 1;
     for (int i = 1; i <= B; i++)
     {
       result*=A;
     }
      Console.WriteLine("Число {0}^{1} = {2}", A, B, result);
      Console.ReadKey();
}
}