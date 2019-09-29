using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalCopy.Tests
{
    [TestClass()]
    public class UnitTestsDriverTests
    {
        [TestClass()]
        public class AddMovieTests
        {
            [TestMethod()]
            public void TestConnection()
            {
                UnitTestsDriver db = new UnitTestsDriver();
                try
                {
                    db.ConnectionTest();

                }
                catch (SystemException e)
                {
                    Console.WriteLine("Connection Failed");
                    return;
                }
                Assert.Fail("Connection successfully made");
            }
            [TestMethod()]
            public void ReadTest()
            {
                UnitTestsDriver db = new UnitTestsDriver();
                try
                {
                    db.DataReadTest();

                }
                catch (SystemException e)
                {
                    Console.WriteLine("Read Failed");
                    return;
                }
                Assert.Fail("Data Read Successfully");

            }
        }
    }
}