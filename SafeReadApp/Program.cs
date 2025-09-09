namespace SafeReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal d1 = 0m;
            decimal d2 = 0m;

            Console.WriteLine("Insert 2 decimal");

            if (!decimal.TryParse(Console.ReadLine(), out d1))
            {
                Console.WriteLine("Error in input");
                return;

            }

            if (!decimal.TryParse(Console.ReadLine(), out d2))
            {
                Console.WriteLine("Error in input");
                return;

            }

            Console.WriteLine($"d1: {d1}, d2: {d2}");
        }
    }
}
