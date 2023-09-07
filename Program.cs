namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ditt namn:");
            String name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"Hej {name}, dagens datum är: {currentDate:d}");

        }
    }
}