using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendingRunner;
using NUnit.Framework;

namespace TrendingTestNUnit
{
    [TestClass]
    public class NUnitTest
    {
        [TestCase]
        public void Test_Trending()
        {
            var result = TrendingRunner.Trending.WhatsTrending(1);
            NUnit.Core.NUnitFramework.Assert.AreEqual("Phoebe Snetsinger", result);

        }
    }
}

Test Name:	Test_Trending()
Test FullName:	TrendingTestNUnit.NUnitTest.Test_Trending()
Test Source:	C:\Users\gzhang.Enterprise\Documents\Visual Studio 2015\Projects\Bank\TrendingTestNUnit\NUnitTest.cs : line 13
Test Outcome:	Failed
Test Duration:	0:00:00.013

Result StackTrace:	
at NUnit.Core.NUnitFramework.get_FrameworkAssembly()
   at NUnit.Core.NUnitFramework.Assert.get_AssertType()
   at NUnit.Core.NUnitFramework.Assert.get_AreEqualMethod()
   at NUnit.Core.NUnitFramework.Assert.AreEqual(Object expected, Object actual)
   at TrendingTestNUnit.NUnitTest.Test_Trending() in C:\Users\gzhang.Enterprise\Documents\Visual Studio 2015\Projects\Bank\TrendingTestNUnit\NUnitTest.cs:line 15
--FileNotFoundException
   at NUnit.Core.NUnitFramework..cctor()
Result Message:	
System.TypeInitializationException : The type initializer for 'NUnit.Core.NUnitFramework' threw an exception.
  ----> System.IO.FileNotFoundException : Could not load file or assembly 'nunit.core.interfaces, Version=2.6.4.14350, Culture=neutral, PublicKeyToken=96d09a1eb7f44a77' or one of its dependencies.The system cannot find the file specified.


