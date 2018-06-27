using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomDimensionCalculations
{
    public class RoomMath
    {
        public static double floorArea(double roomWidth, double roomLength)
        {
            if (Double.IsInfinity(roomWidth) || roomWidth <= 0)
                throw new ArgumentOutOfRangeException("roomWidth");
            if (Double.IsInfinity(roomLength) || roomLength <= 0)
                throw new ArgumentOutOfRangeException("roomLength");

            double area = roomWidth * roomLength;

            if (Double.IsInfinity(area))
                throw new ArithmeticException("Room dimensions are too large");

            return area;
        }
        public static double roomVolume(double roomWidth, double roomLength, double roomHeight)
        {
            if (Double.IsInfinity(roomWidth) || roomWidth <= 0)
                throw new ArgumentOutOfRangeException("roomWidth");
            if (Double.IsInfinity(roomLength) || roomLength <= 0)
                throw new ArgumentOutOfRangeException("roomLength");
            if (Double.IsInfinity(roomHeight) || roomHeight <= 0)
                throw new ArgumentOutOfRangeException("roomHeight");

            double volume = roomWidth * roomLength * roomHeight;

            if (Double.IsInfinity(volume))
                throw new ArithmeticException("Room dimensions are too large");

            return volume;
        }
        public static double paintRequired(double roomWidth, double roomLength, double roomHeight, double paintArea)
        {
            if (Double.IsInfinity(roomWidth) || roomWidth <= 0)
                throw new ArgumentOutOfRangeException("roomWidth");
            if (Double.IsInfinity(roomLength) || roomLength <= 0)
                throw new ArgumentOutOfRangeException("roomLength");
            if (Double.IsInfinity(roomHeight) || roomHeight <= 0)
                throw new ArgumentOutOfRangeException("roomHeight");
            if (Double.IsInfinity(paintArea) || paintArea <= 0)
                throw new ArgumentOutOfRangeException("paintArea");

            double wallArea = (roomWidth * roomHeight * 2 + 
                            roomLength * roomHeight * 2);

            if (Double.IsInfinity(wallArea))
                throw new ArithmeticException("Room dimensions are too large");

            return wallArea / paintArea;
        }
    }
}
