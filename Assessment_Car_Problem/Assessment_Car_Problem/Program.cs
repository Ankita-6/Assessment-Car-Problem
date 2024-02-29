using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Car_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display();
        }
        public static void Display()
        {

            long sold1 = 0; // for month with 30days
            long sold2 = 0; // for month with 31 days
            long retailersCount = 0;
            long corporateCount = 0;
            int i;
            for (i = 1; i <= 30; i++)
            {
                sold1 = sold1 + (i * i) - (i - 1);

                if (i % 5 == 0)
                {
                    corporateCount += (i * i) - (i - 1);
                }
                else
                {
                    retailersCount += (i * i) - (i - 1);
                }

            }
            //for 31st day 
            long extra = (i * i) - (i - 1);
            sold2 =sold1 + extra;
            retailersCount = retailersCount * 6 + extra * 3; // april to sept
            corporateCount = corporateCount * 6 ;

            Console.WriteLine("Sales Information from April 1st to Sep 30th");
            Console.WriteLine("No of vEhicles Sold in each Month");
            Console.WriteLine($"April : {sold1}");
            Console.WriteLine($"May : {sold2}");
            Console.WriteLine($"June : {sold1}");
            Console.WriteLine($"July : {sold2}");
            Console.WriteLine($"August : {sold2}");
            Console.WriteLine($"September : {sold1}");

            Console.WriteLine("No of Vehicles sold to retail customers : " + retailersCount);
            Console.WriteLine("No of Vehicles sold to corporate customers : " + corporateCount);
            int AugSept = 0;
            for (int j = 15; j <= 31; j++)
            {
                AugSept = AugSept + (j * j) - (j - 1);
            }
            for (int j = 1; j <= 15; j++)
            {
                AugSept = AugSept + (j * j) - (j - 1);
            }

            Console.WriteLine("No of Vehicles sold from Aug15 to sept 15 : " + AugSept);


        }
    }
}
