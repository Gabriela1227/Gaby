using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CollectionsSampleTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //Arrange
            Customer[] customers = new Customer[2] {new Customer { FirstName = "John", LastName = "Ford"},
                                                    new Customer {FirstName = "Billy", LastName = "Wilder"}};

            int index = 1;
            Customer expected = customers[1];

            //Act
            Customer actual = ColletionsSample.GetCustomer(customers, index);


            //Assert
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutofRangeException()
        {
            //Arrange
            Customer[] customers = new Customer[2] {new Customer { FirstName = "John", LastName = "Ford"},
                                                    new Customer {FirstName = "Billy", LastName = "Wilder"}};

            int index = 3;

            //Act
            ColletionsSample.GetCustomer(customers, index);

            //Assert

        }

    }




}
