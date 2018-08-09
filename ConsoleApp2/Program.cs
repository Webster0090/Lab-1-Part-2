using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a date using the MM/DD/YYYY format: ");
            
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Please enter a second date using the MM/DD/YYYY format: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            
            TimeSpan difference = new TimeSpan();

            
            int firstDateisGreater = DateTime.Compare(firstDate, secondDate);


            
            if (firstDateisGreater > -1)
            {
                difference = firstDate - secondDate;
            }
            else
            {
                difference = secondDate - firstDate;
            }

            

            Console.WriteLine("\nRESULTS:\n");
            Console.WriteLine("Days: " + string.Format("{0:n0}", difference.TotalDays));
            Console.WriteLine("Hours: " + string.Format("{0:n0}", difference.TotalHours));
            Console.WriteLine("Minutes: " + string.Format("{0:n0}", difference.TotalMinutes));


            Console.WriteLine("\n\nPress any key to exit application...");
            Console.ReadLine();

            
        }
    }
}
