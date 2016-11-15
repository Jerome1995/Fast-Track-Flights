using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fast_Track_Flights;

namespace Fast_Track_Flights_Tests
{
    /// <summary>
    /// Summary description for SearchTest
    /// </summary>
    [TestClass]
    public class SearchTest
    {
        

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void searchFlightsTest()
        {
            Search booking = new Search();
            DepartFlight depart = new DepartFlight();
            ReturnFlight returnFlight = new ReturnFlight();
            depart.Airport = "Dublin";
            depart.Date = "05/11/16";
            returnFlight.Airport = "Paris(CDG)";
            returnFlight.Date = "12/11/16";
            bool result = booking.searchFlights(depart,returnFlight);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void searchOnwWayFlightTest()
        {
            Search booking = new Search();
            DepartFlight depart = new DepartFlight();
            depart.Airport = "Dublin";
            depart.Date = "05/11/16";
            bool result = booking.searchOneWay(depart);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
    }
}
