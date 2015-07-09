using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace Accumulation
namespace Accumulation
{
    /// <summary> 
    /// This program will accumulate and print the amount of the money deposited by a woman over different period of time. 
    /// </summary>

    //class start
    class Program
    {
        //main function
        static void Main(string[] args)
        {
            //declaring varibales
            double money = 35.49;
            double perYear = money * 365;            
            double twoYears = 0;
            double fiveYears = 0;
            double tenYears = 0;

            //to calculate the first year deposit we don't need a loop
            Console.WriteLine("First year women deposited total of " + perYear.ToString("C2") + "\n");

            //for loop to calculate the money deposited during the years
            for ( double i = 0; i < 2; i++ )
            {
                twoYears = twoYears + ( 35.49 * 365 ) ;                
            }
            for (double i = 0; i < 5; i++)
            {
                fiveYears = fiveYears + (35.49 * 365);
            }
            for (double i = 0; i < 10; i++)
            {
                tenYears = tenYears + (35.49 * 365);
            }//end for loop

            //print out the final values
            Console.WriteLine("In two years women deposited total of " + twoYears.ToString( "C2" ) + "\n" );
            Console.WriteLine("In five years women deposited total of " + fiveYears.ToString("C2") + "\n");
            Console.WriteLine("In ten years women deposited total of " + tenYears.ToString("C2") + "\n");
            Console.ReadLine();         
        }//end main method
    }//end class program
}//end namespace Accumulation