using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using TicketClassLibrary;


namespace StoreBaeltTicketLibrary.Tests
{

    /// <summary>
    /// Indeholder test for Car-klassen.
    /// </summary>
    [TestClass]
    public class CarTest
    {
        /// <summary>
        /// Tester prisen på en bil uden BroBizz.
        /// </summary>
        [TestMethod]
        public void CarPriceWithoutBroBizzTest()
        {
            // Arrange
            Car car = new Car("ABC123", DateTime.Now, false); // Uden BroBizz

            // Act
            double price = car.Price;

            // Assert
            Assert.AreEqual(240, price); // Grundprisen bør være 240
        }

        /// <summary>
        /// Tester prisen på en bil med BroBizz.
        /// </summary>
        [TestMethod]
        public void CarPriceWithBroBizzTest()
        {
            // Arrange
            Car car = new Car("ABC123", DateTime.Now, true); // Med BroBizz

            // Act
            double price = car.Price;

            // Assert
            Assert.AreEqual(240 * 0.95, price); // Pris efter 5% rabat
        }
    }

    /// <summary>
    /// Indeholder enhedstests for MC-klassen.
    /// </summary>
    [TestClass]
    public class MCTest
    {
        /// <summary>
        /// Tester prisen på en MC uden BroBizz.
        /// </summary>
        [TestMethod]
        public void MCPriceWithoutBroBizzTest()
        {
            // Arrange
            MC mc = new MC("ABDI123", DateTime.Now); // Prisen er fastsat til 125

            // Act
            double price = mc.Price;

            // Assert
            Assert.AreEqual(125, price); // MC-prisen skal altid være 125
        }

        /// <summary>
        /// Tester prisen på en MC med BroBizz.
        /// </summary>
        [TestMethod]
        public void MCPriceWithBroBizzTest()
        {
            // Arrange
            MC mc = new MC("ABDI123", DateTime.Now); // Prisen er fastsat til 125

            // Act
            double priceWithBroBizz = mc.ApplyBroBizzDiscount(mc.Price, true); // Anvender rabatten

            // Assert
            Assert.AreEqual(125, priceWithBroBizz); // MC-prisen skal forblive 125 uanset BroBizz
        }
    }
}
