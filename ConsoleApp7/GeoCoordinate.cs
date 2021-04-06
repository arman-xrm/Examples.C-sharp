using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class GeoCoordinate
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public GeoCoordinate()
        {
        }
        public GeoCoordinate(int coordinateX, int coordinateY)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
        }

        public static GeoCoordinate operator +(GeoCoordinate ob1, GeoCoordinate ob2)
        {
            GeoCoordinate ob = new GeoCoordinate();
            ob.CoordinateX = ob1.CoordinateX + ob2.CoordinateX;
            ob.CoordinateY = ob1.CoordinateY + ob2.CoordinateY;

            return ob;
        }

    }
}
