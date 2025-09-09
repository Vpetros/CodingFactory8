using System.Globalization;


namespace WriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Δήλωση και Αρχικοποίηση Μεταβλητών
            int num1 = 10;
            int num2 = 20;
            int result = 0;

            //Εντολές
            result = num1 + num2;

            //Εκτύπωση Αποτελεσμάτων
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is: " + result);
            Console.WriteLine("Sum of {0} and {1} is: {2}", num1, num2, result);
            Console.WriteLine($"Sum of {num1} and {num2} is: {result}");
        }
    }
}
