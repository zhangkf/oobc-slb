using System;
using System.Drawing;

namespace OOBC
{
    public class PointParser
    {

        public static Point ToPoint(string point)
        {
            string[] axis = point.Split(Convert.ToChar(","));
            return new Point(int.Parse(axis[0]), int.Parse(axis[1]));
        }
    }
}