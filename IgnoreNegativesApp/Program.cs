using System.Threading.Channels;

namespace IgnoreNegativesApp
{
    /// <summary>
    /// Μετράει το πλήθος των θετικών όσο το
    /// input δεν είναι μηδέν.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Λάθος κατα την εισαγωγή");
                return;
            }

            while (num >= 0)
            {
                if (num > 0) count++;

                Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Λάθος κατα την εισαγωγή");
                    return;

                }
                Console.WriteLine($"Το πλήθος των θετικών είναι: {count}");

            }
        }
    }
}