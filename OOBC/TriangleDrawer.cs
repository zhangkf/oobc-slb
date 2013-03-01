using System.Collections.Generic;
using System.Drawing;

namespace OOBC
{
    public class TriangleDrawer: ShapeDrawer
    {
        private const int TRIANGLE_POINTS_NUMBER = 3;

        public TriangleDrawer()
        {
            this.Points = new List<Point>(TRIANGLE_POINTS_NUMBER);
        }

        public override Shape Draw()
        {
            if (Points.Count < 3)
            {
                throw new NotEnoughPointsForDrawingException();
            }
            return new Triangle(Points[0], Points[1], Points[2]);
        }
    }
}