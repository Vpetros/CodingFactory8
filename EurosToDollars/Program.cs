using System.Text;

namespace EurosToDollars
{
    /// <summary>
    /// Διαβάζει απτο std έναν ακέραιο που αναπαριστά
    /// το ποσό σε ευρώ. Και μετατρέπει απο ευρώ σε δολλάρια,
    /// με βάση μια ισοτιμία έστω 1 ευρώ = 1.07 USD.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal RATE = 1.07m;
            decimal totalCents;
            decimal dollars;
            decimal cents;

            Console.WriteLine("Insert amount in Euro");
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputEuros))
            {
                Console.WriteLine("Error in input");
                return;
            }

            totalCents = inputEuros * RATE;
            dollars = totalCents / 100;
            cents = totalCents % 100;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\u20AC {inputEuros:N2} αντιστοιχούν σε \u0024 {totalCents: N0} {cents,5:N0} cents");







        }
    }
}
