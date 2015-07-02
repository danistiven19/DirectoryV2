using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DirectoryBusinessLogic.Aplicacion;
using DirectoryPersistence.Entities;

namespace DirectoryTest.BusinessPersonTest
{
    /// <summary>
    /// Summary description for BusinessPersonTest
    /// </summary>
    [TestClass]
    public class BusinessPersonTest
    {
        private BusinessPerson _businessPerson;

        public BusinessPersonTest()
        {
            _businessPerson = new BusinessPerson(); 
        }

       
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
        public void GetAllPersonsTest()
        {
            IList<Person> persons = (IList<Person>)  _businessPerson.getAllPersons();
            Assert.AreNotEqual(persons.Count, 0);

        }
    }
}
