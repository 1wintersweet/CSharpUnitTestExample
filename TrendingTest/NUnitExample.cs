using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TrendingRunner;

namespace TrendingTest
{
    class NUnitExample
    {
        // [TestCase]                  // this mark the method as a test in Nunit
        //have multiple tests defined as decorations above the method
        //no need to use the Assert now, you just return, and let NUnit take care of the rest
        [TestCase(1, ExpectedResult = "Phoebe Snetsinger")]
        [TestCase(2, ExpectedResult = "Gersh Kuntzman")]
        [TestCase(3, ExpectedResult = "Victoria Woodhull")]

        public string Test_Trending_nUnit(int anIndex)
        {
            Console.Out.WriteLine("Call \t-> \tresult :\r\n  {0} \t-> \t\"{1}\""
                         , anIndex
                         , TrendingRunner.Trending.WhatsTrending(anIndex));

           

            return TrendingRunner.Trending.WhatsTrending(anIndex);
            //Assert.AreEqual("Phoebe Snetsinger", result);
        }

    }
}
