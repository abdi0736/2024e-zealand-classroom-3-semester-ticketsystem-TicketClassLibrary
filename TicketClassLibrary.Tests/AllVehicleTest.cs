using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
[TestSubject(typeof(Car))]
public class AllVehicleTest
{

   
    [TestMethod]
    public void VehicleTest()
    {
        //arrange
        Car car0 = new Car();
        
        //act
        string car0Name = "Car";
        
        //assert
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





    [TestClass]
    [TestSubject(typeof(MC))]
    public class MCTest
    {

        [TestMethod]
        public void TestMCprice()
        {

            //arrange   
            MC mc0 = new MC();

            //act
            string mc0Name = "MC";

            //assert
            Assert.AreEqual("MC", mc0Name);
        }
        
        [TestMethod]
        public void MakepricemcTest()
        {
            // Arrange
            MC mc1 = new MC();

            // Act
            double mc1Price = mc1.Price;

            // Assert
            Assert.AreEqual(125, mc1Price);
        }

    }
}

