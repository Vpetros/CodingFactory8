namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβάζει ένα string είσοδο και προσπαθεί 
    /// να μετατρέψει σε int και ελέγχει με try/catch
    /// για FormatException
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                try
                {
                    Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο (0 για έξοδο)");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Εισάγατε τον ακέραιο: {num}");
                    if (num == 0) break;
                    
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            }
        }
    }


