using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Intro.Model.Tests
{
    [TestClass]
    public class PhysicalTest
    {
        [TestMethod]
        public void CreateNewPhysical()
        {
            Physical person = new Physical()
            {
                Id = Guid.NewGuid(),
                Name = "Name for Person 1",
                BornDate = DateTime.Parse("01/01/2000")
            };

            Assert.IsNotNull(person);
            Assert.AreEqual(DateTime.Parse("01/01/2000"), person.BornDate);
        }

        [TestMethod]
        public void GetPersonSummarizedInfo()
        {
            Physical person = new Physical()
            {
                Id = Guid.NewGuid(),
                Name = "Name for Person 1",
                BornDate = DateTime.Parse("01/01/2000")
            };

            Assert.IsNotNull(person);
            Assert.AreEqual("Name: Name for Person 1, Born Date: 01/01/2000", person.GetSummarizedInfo());
        }
    }
}