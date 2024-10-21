using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;

namespace StoreBaeltTicketLibrary.Tests;

[TestClass]
[TestSubject(typeof(OresundMC))]
public class OresundMCTest
{

    [TestClass]
    public class OresundTicketTests
    {
        [TestMethod]
        public void OresundCarRegularPriceTest()
        {
            OresundCar car = new OresundCar("AB12345", DateTime.Now, false);
            Assert.AreEqual(410, car.Price);
        }

        [TestMethod]
        public void OresundCarBrobizzPriceTest()
        {
            OresundCar car = new OresundCar("AB12345", DateTime.Now, true);
            Assert.AreEqual(161, car.Price);
        }

        [TestMethod]
        public void OresundMRegularPriceTest()
        {
            OresundMC mc = new OresundMC("AB12345", DateTime.Now, false);
            Assert.AreEqual(210, mc.Price);
        }

        [TestMethod]
        public void OresundMCBrobizzPriceTest()
        {
            OresundMC mc = new OresundMC("AB12345", DateTime.Now, true);
            Assert.AreEqual(73, mc.Price);
        }

        [TestMethod]
        public void VehicleTypeTestCar()
        {
            OresundCar car = new OresundCar("AB12345", DateTime.Now);
            Assert.AreEqual("Oresund car", car.Vehicletype());
        }

        [TestMethod]
        public void VehicleTypeTestMC()
        {
            OresundMC mc = new OresundMC("AB12345", DateTime.Now);
            Assert.AreEqual("Oresund MC", mc.Vehicletype());
        }
    }
}