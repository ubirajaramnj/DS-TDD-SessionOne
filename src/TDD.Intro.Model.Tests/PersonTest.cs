using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Intro.Model.Tests
{
    [TestClass]
    public class PersonTest
    {
        Person _person;

        [TestInitialize]
        public void Initilize()
        {
            _person = new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Name for Person 1",
            };
        }

        [TestMethod]
        public void CreateNewPerson()
        {
            Assert.IsNotNull(_person);
            Assert.AreEqual("Name for Person 1", _person.Name);
        }

        [TestMethod]
        public void CreateNewPersonWithMultipleAddress()
        {
            _person.Addresses.Add(new Address()
            {
                AddressLineOne = "Address Line One",
                AddressLineTwo = "Address Line Two",
                City = "Toronto",
                Province = "Ontario",
                Country = "Canada"
            });

            Assert.IsNotNull(_person);
            Assert.AreEqual("Name for Person 1", _person.Name);
            Assert.AreEqual("Address Line One", _person.Addresses.FirstOrDefault().AddressLineOne);
            Assert.AreEqual("Address Line Two", _person.Addresses.FirstOrDefault().AddressLineTwo);
        }

        [TestMethod]
        public void GetPersonSummarizedInfo()
        {
            Assert.IsNotNull(_person);
            Assert.AreEqual("Name: Name for Person 1", _person.GetSummarizedInfo());
        }
    }
}