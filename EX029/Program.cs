internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество генерируемых чисел: ");
       int n = Convert.ToInt32(Console.ReadLine());
       int [] arr = new int [n];
       Random rnd = new Random();
       Console.Write("Сгенерируемый массив: ");
       for (int i = 0; i < arr.Length; i++)
       {
            arr[i]=rnd.Next(-20,20);
       }

       for (int i = 0; i < arr.Length; i++)
       {
        Console.Write("{0}, ",arr[i]);
       }

        Array.Sort(arr);
        Console.Write("\nОтсортированный по модулю массив: ");
        foreach (int a in arr)
        {
            Console.Write("{0}, ",a);
        }
    }
}