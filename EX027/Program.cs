internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.Write("Введите длину числа: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] number = new double[n];
        Console.WriteLine("Введите число");
        for (int i = 0; i < number.Length; i++)
        {
             number[i] =  Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("Введенное число: ");
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("{0} ",number[i]);
        }
        double result= 0;
        foreach (double item in number){
            result +=item; 
        }
        Console.Write("\nCумма элементов числа: {0}",result);
    }
}