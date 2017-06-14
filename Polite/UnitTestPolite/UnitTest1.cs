using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polite;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestPolite
{
    [TestClass]
    public class UnitTest1
    {
     

        [TestMethod]
        public void getLogFileDirectory()
        {
            try
            {


                FileHandler filehandler = new FileHandler();
                filehandler.getLogFileDirectory();

            }
            catch (Exception ex)
            {
                Assert.Fail("Could not log file." + ex.Message);

            }

        }

        [TestMethod]
        public void getCSVDirectory()
        {
            try
            {


                FileHandler filehandler = new FileHandler();
                filehandler.getCSVDirectory();

            }
            catch (Exception ex)
            {
                Assert.Fail("Could not find CSV file." + ex.Message);

            }

        }
        [TestMethod]
        public void getMyAddresssDirectory()
        {
            try
            {


                FileHandler filehandler = new FileHandler();
                filehandler.getMyAddresssDirectory();

            }
            catch (Exception ex)
            {
                Assert.Fail("Could not find myAddress file directory." + ex.Message);

            }

        }

        [TestMethod]
        public void getMyNameDirectory()
        {
            try
            {


                FileHandler filehandler = new FileHandler();
                filehandler.getMyNameDirectory();

            }
            catch (Exception ex)
            {
                Assert.Fail("Could not find myNamefile directory." + ex.Message);

            }

        }

        [TestMethod]
        public void sortedNames()
        {
           

                FileHandler h = new FileHandler();
                FileProcessor f = new FileProcessor();

               Dictionary<string,int> list1= f.SortNames(h.getFileContents());
                Dictionary<string, int> list2 = new Dictionary<string, int>{
                    {"Brown", 2 },
                    {"Clive", 2 },
                    {"Graham", 2},
                    {"Howe", 2 },
                    { "James", 2},
                    { "Owen", 2 },
                    {"Smith", 2 },
                    {"Jimmy", 1 },
                    {"John", 1 }
                };

                var firstNotSecond = list1.Except(list2).ToList();
                var secondNotFirst = list2.Except(list1).ToList();
                 Assert.IsTrue(!firstNotSecond.Any() && !secondNotFirst.Any());
               
            }
        [TestMethod]
        public void sortedAddresses()
        {


            FileHandler h = new FileHandler();
            FileProcessor f = new FileProcessor();

            Dictionary<int,string> list1 = f.SortAddress(h.getFileContents());
            Dictionary<int, string> list2 = new Dictionary<int, string>{
                {65,"Ambling Way"},
                {8,"Crimson Rd"},
                {12,"Howard St"},
                {102,"Long Lane"},
                {94,"Roland St"},
                {78,"Short Lane"},
                {82,"Stewart St"},
                {49,"Sutherland St"}
                };

            var firstNotSecond = list1.Except(list2).ToList();
            var secondNotFirst = list2.Except(list1).ToList();
            Assert.IsTrue(!firstNotSecond.Any() && !secondNotFirst.Any());

        }


    }
}
