using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fast_Track_Flights;

namespace Fast_Track_Flights_Tests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void bookFlightsTest()
        {
            Book booking = new Book();
            Customer customer = new Customer();
            Payment payment = new Payment();
            customer.title = "Mr";
            customer.surname = "Jerome";
            customer.forename = "O'Connor";
            customer.age = 21;
            customer.email = "1995jerome@gmail.com";
            customer.phoneNumber = "0876725301";
            customer.address_1 = "Ballykissane";
            customer.address_2 = "Killorglin";
            customer.town = "Killorglin";
            customer.county = "Kerry";
            customer.country = "Ireland";
            customer.nationaility = "Irish";
            payment.cardType = "Visa";
            payment.cardNumber = "1234567812345678";
            payment.cardHolderName = "Jerome O'Connor";
            payment.expiry = "01/02/2020";
            payment.amount = 150.45;
            payment.csc = "123";
            bool result = booking.bookFlight(customer, payment);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
    }
}
