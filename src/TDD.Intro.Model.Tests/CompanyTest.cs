using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Intro.Model.Tests
{
    [TestClass]
    public class CompanyTest
    {
        Company _company;

        [TestInitialize]
        public void Initilize()
        {
            _company = new Company()
            {
                Id = Guid.NewGuid(),
                Name = "Name for Company 1",
                IdentificationCode = "Identification Code"
            };
        }

        [TestMethod]
        public void CreateNewCompany()
        {
            Assert.IsNotNull(_company);
            Assert.AreEqual("Name for Company 1", _company.Name);
            Assert.AreEqual("Identification Code", _company.IdentificationCode);
        }

        [TestMethod]
        public void CreateNewCompanyWithAddress()
        {
            _company.Addresses.Add(new Address()
            {
                AddressLineOne = "Address Line One",
                AddressLineTwo = "Address Line Two",
                City = "Toronto",
                Province = "Ontario",
                Country = "Canada"
            });

            Assert.IsNotNull(_company);
            Assert.AreEqual("Name for Company 1", _company.Name);
            Assert.AreEqual("Identification Code", _company.IdentificationCode);
            Assert.AreEqual("Address Line One", _company.Addresses.FirstOrDefault().AddressLineOne);
            Assert.AreEqual("Address Line Two", _company.Addresses.FirstOrDefault().AddressLineTwo);
        }

        [TestMethod]
        public void GetCompanySummarizedInfo()
        {
            Assert.IsNotNull(_company);
            Assert.AreEqual("Name: Name for Company 1, Identification Code: Identification Code", _company.GetSummarizedInfo());
        }
    }
}
