using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

/// <summary>
/// Contains unit tests for vehicles such as cars and motorcycles.
/// </summary>
[TestClass]
public class AllVehicleTest
{
    /// <summary>
    /// Tester, at køretøjstypen, som Car-klassen returnerer, er "Car".
    /// </summary>
    [TestMethod]
    public void VehicleTypeTestCar()
    {
        // Arrange
        Car car = new Car("AB12345", DateTime.Now);

        // Act
        string vehicleType = car.Vehicletype();

        // Assert
        Assert.AreEqual("Car", vehicleType);
    }

    /// <summary>
    /// Indeholder tests for Car-klassen.
    /// </summary>
    [TestClass]
    public class CarTests
    {
        /// <summary>
        /// Tester, at prisen på en bil med både weekendrabat og BroBizz-rabat beregnes korrekt.
        /// </summary>
        [TestMethod]
        public void TestWeekendDiscountWithBroBizz()
        {
            // Arrange
            var car = new Car("AB12345", new DateTime(2024, 10, 5), true); // Lørdag
            double expectedPrice = 240 * 0.8 * 0.95; // 20% weekendrabat + 5% BroBizz

            // Act
            double actualPrice = car.Price;

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.01,
                "Prisen skal beregnes korrekt med både weekend- og BroBizz-rabatter.");
        }

        /// <summary>
        /// Tester, at prisen på en bil kun beregnes med weekendrabat (uden BroBizz).
        /// </summary>
        [TestMethod]
        public void TestNoDiscounts()
        {
            // Arrange
            var car = new Car("AB12345", new DateTime(2024, 10, 6), false); // Søndag
            double expectedPrice = 240 * 0.8; // 20% weekendrabat kun

            // Act
            double actualPrice = car.Price;

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.01,
                "Prisen skal beregnes korrekt kun med weekendrabat.");
        }

        /// <summary>
        /// Tester, at prisen på en bil uden BroBizz er 240.
        /// </summary>
        [TestMethod]
        public void PriceWithoutBroBizzCarTest()
        {
            // Arrange
            Car car = new Car("AB12345", DateTime.Now, false);

            // Act
            double carPrice = car.Price;

            // Assert
            Assert.AreEqual(240, carPrice);
        }

        /// <summary>
        /// Tester, at prisen på en bil med BroBizz er 95% af 240.
        /// </summary>
        [TestMethod]
        public void PriceWithBroBizzCarTest()
        {
            // Arrange
            Car car = new Car("AB12345", DateTime.Now, true);

            // Act
            double carPrice = car.Price;

            // Assert
            Assert.AreEqual(240 * 0.95, carPrice);
        }
    
        /// <summary>
        /// Teste om den ukorrekte nummerplade for fejl besked
        /// </summary>
        [TestMethod]
        public void LicensePlateInvalidTestCar()
        {
            // Arrange
            var car = new Car("AB12345", DateTime.Now);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = "INVALID123");
        }

        /// <summary>
        /// Teste MC klassen 
        /// </summary>
        [TestClass]
        public class MCTest
        {
            /// <summary>
            /// Test om vehiceltype er MC
            /// </summary>
            [TestMethod]
            public void VehicleTypeTestMC()
            {
                // Arrange
                MC mc = new MC("AB12345", DateTime.Now);

                // Act
                string vehicleType = mc.Vehicletype();

                // Assert
                Assert.AreEqual("MC", vehicleType);
            }

            /// <summary>
            /// Tester at prisen på MC er 125
            /// </summary>
            [TestMethod]
            public void PriceWithoutBroBizzMCTest()
            {
                // Arrange
                MC mc = new MC("AB12345", DateTime.Now);

                // Act
                double mcPrice = mc.Price;

                // Assert
                Assert.AreEqual(125, mcPrice);
            }

            /// <summary>
            /// Tester at MC nummer plade er korrekt
            /// </summary>
            [TestMethod]
            public void LicensePlateInvalidTestMC()
            {
                // Arrange
                var mc = new MC("AB12345", DateTime.Now);

                // Act & Assert
                Assert.ThrowsException<ArgumentException>(() => mc.LicensePlate = "INVALID123");
            }

            /// <summary>
            /// Teste om nummerpladen er korrekt
            /// </summary>
            [TestMethod]
            public void LicensePlateValidTestMC()
            {
                // Arrange
                MC mc = new MC("AB12345", DateTime.Now);

                // Act
                string licensePlate = mc.LicensePlate;

                // Assert
                Assert.AreEqual("AB12345", licensePlate);
            }
        }
    }
}