using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commission_of_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter Amount: ");

                decimal sales = decimal.Parse(Console.ReadLine());
                decimal commission = sales * 6.5M / 100;
                Console.WriteLine($"Commission  rate is : {commission:0.00}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
            finally
            {
                Console.WriteLine();

            }

            Console.ReadKey();


        }
    }
}
