namespace Assignment_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNaturalNumbers = 0;
            Console.WriteLine("This program sums the number of natural numbers you define.");
            Console.WriteLine("Enter how many natural numbers you want to sum:");
            int totalNaturalNumbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first " +totalNaturalNumbers+ " natural number are:");
            for (int i = 1; i <= totalNaturalNumbers; i++)
            {
                sumNaturalNumbers = sumNaturalNumbers + i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is: " + sumNaturalNumbers);
        }
    }
}
