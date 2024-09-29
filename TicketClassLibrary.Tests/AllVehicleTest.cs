using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class AllVehicleTest
    {
        [TestMethod]
        public void VehicleTest()
        {
            // Arrange
            Car car0 = new Car();

            // Act
            string car0Name = car0.Vehicletype();

            // Assert
            Assert.AreEqual("Car", car0Name);
        }

        [TestMethod]
        public void MakepricecarTest()
        {
            // Arrange
            Car car1 = new Car();

            // Act
            double car1Price = car1.Price;

            // Assert
            Assert.AreEqual(240, car1Price);
        }

        [TestMethod]
        public void LicensePlateTestcar()
        {
            // Arrange
            var car = new Car();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = "ABDI1234");
        }

        [TestClass]
        [TestSubject(typeof(MC))]
        public class MCTest
        {
            [TestMethod]
            public void TestMCprice()
            {
                // Arrange
                MC mc0 = new MC("ABDI123", DateTime.Now);

                // Act
                string mc0Name = "MC";

                // Assert
                Assert.AreEqual("MC", mc0Name);
            }

            [TestMethod]
            public void MakepricemcTest()
            {
                // Arrange
                MC mc1 = new MC("ABDI123", DateTime.Now);

                // Act
                double mc1Price = mc1.Price;

                // Assert
                Assert.AreEqual(125, mc1Price);
            }

            [TestMethod]
            public void MakelicenseTest()
            {
                // Arrange
                MC mc2 = new MC("ABDI123", DateTime.Now);

                // Act
                string licensePlate = mc2.LicensePlate;

                // Assert
                Assert.AreEqual("ABDI123", licensePlate);
            }
        } 
    }
} 