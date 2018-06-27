using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomDimensionCalculations;

namespace RoomDimensionUnitTest
{
    [TestClass]
    public class RoomCalculationsTests
    {
        [TestMethod]
        public void floorArea_Valid()
        {
            double area = RoomMath.floorArea(10.0, 10.0);
            Assert.AreEqual(100.0, area);
            area = RoomMath.floorArea(1.0, 1.0);
            Assert.AreEqual(1.0, area);
            area = RoomMath.floorArea(0.5, 0.5);
            Assert.AreEqual(0.25, area);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void floorArea_outOfRangeInput()
        {
            RoomMath.floorArea(-10.0, 10.0);
            RoomMath.floorArea(10.0, -10.0);
            RoomMath.floorArea(Double.PositiveInfinity, 10.0);
            RoomMath.floorArea(10.0, Double.PositiveInfinity);
        }
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void floorArea_InputsTooLarge()
        {
            RoomMath.floorArea(Double.MaxValue, Double.MaxValue);
        }

        [TestMethod]
        public void roomVolume_Valid()
        {
            double volume = RoomMath.roomVolume(10.0, 10.0, 10.0);
            Assert.AreEqual(1000.0, volume);
            volume = RoomMath.roomVolume(1.0, 1.0, 1.0);
            Assert.AreEqual(1.0, volume);
            volume = RoomMath.roomVolume(0.5, 0.5, 0.5);
            Assert.AreEqual(0.125, volume);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void roomVolume_outOfRangeInput()
        {
            RoomMath.roomVolume(-10.0, 10.0, 10.0);
            RoomMath.roomVolume(10.0, -10.0, 10.0);
            RoomMath.roomVolume(10.0, 10.0, -10.0);
            RoomMath.roomVolume(Double.PositiveInfinity, 10.0, 10.0);
            RoomMath.roomVolume(10.0, Double.PositiveInfinity, 10.0);
            RoomMath.roomVolume(10.0, 10.0, Double.PositiveInfinity);
        }
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void roomVolume_InputsTooLarge()
        {
            RoomMath.roomVolume(Double.MaxValue, Double.MaxValue, Double.MaxValue);
        }

        [TestMethod]
        public void paintRequired_Valid()
        {
            double volume = RoomMath.paintRequired(10.0, 10.0, 10.0, 10.0);
            Assert.AreEqual(40.0, volume);
            volume = RoomMath.paintRequired(1.0, 1.0, 1.0, 1.0);
            Assert.AreEqual(4.0, volume);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void paintRequired_outOfRangeInput()
        {
            RoomMath.paintRequired(-10.0, 10.0, 10.0, 10.0);
            RoomMath.paintRequired(10.0, -10.0, 10.0, 10.0);
            RoomMath.paintRequired(10.0, 10.0, -10.0, 10.0);
            RoomMath.paintRequired(10.0, 10.0, 10.0, -10.0);
            RoomMath.paintRequired(Double.PositiveInfinity, 10.0, 10.0, 10.0);
            RoomMath.paintRequired(10.0, Double.PositiveInfinity, 10.0, 10.0);
            RoomMath.paintRequired(10.0, 10.0, Double.PositiveInfinity, 10.0);
            RoomMath.paintRequired(10.0, 10.0, 10.0, Double.PositiveInfinity);
        }
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void paintRequired_InputsTooLarge()
        {
            RoomMath.paintRequired(Double.MaxValue, Double.MaxValue, Double.MaxValue, Double.MaxValue);
        }
    }
}
