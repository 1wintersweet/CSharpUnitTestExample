using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendingRunner;

namespace TrendingTest
{
    [TestClass]
    public class MSTestExample
    {

        /// <summary>
        /// We would prefer one test method one asert
        /// </summary>
        [TestMethod]

        public void Test_Trending_MSTest_OK()
        {

            //Assuming we want to make sure that our unit tests cover all execution paths, 
            //we might add conditions to our test method, so it might be looking like:
            string result = TrendingRunner.Trending.WhatsTrending(1);
            Assert.AreEqual("Phoebe Snetsinger", result);

            result = TrendingRunner.Trending.WhatsTrending(2);
            Assert.AreEqual("Gersh Kuntzman", result);

            result = TrendingRunner.Trending.WhatsTrending(3);
            Assert.AreEqual("Victoria Woodhull", result);
        }
    }
}
