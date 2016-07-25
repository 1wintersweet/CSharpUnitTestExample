using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendingRunner
{
   public class Trending
    {
        static void Main(string[] args)
        {

            Console.Out.WriteLine("This will show thrending authors according to {0}"
                , "http://www.google.com/trends/topcharts");
            Console.Out.WriteLine("Hit any key to see the next result.");
            Console.Out.WriteLine("");

            for (int iteration = 1; iteration < 5; iteration++)
            {
                Console.Out.WriteLine("What's trending top list number {0}: {1}."
                    , iteration
                    , WhatsTrending(iteration)
                    );

                Console.ReadKey(true); // wait for a key press
            }
        }

        /// <summary>
        /// Will return the top 3 from : http://www.google.com
        /// </summary>
        /// <param name="anIndex">Which index to return</param>
        /// <returns>A string holding the interest @ index "anInedx"</returns>
        public static string WhatsTrending(int anIndex)
        {
            string answer;
            switch (anIndex)
            {
                case 1:
                    answer = "Phoebe Snetsinger";
                    break;
                case 2:
                    answer = "Gersh Kuntzman";
                    break;
                case 3:
                    answer = "Victoria Woodhull";
                    break;
                default:
                    answer = "Choose an index between 1 or 3, or go and search it yourself.";
                    break;
            }
            return answer;
        }
    }
}