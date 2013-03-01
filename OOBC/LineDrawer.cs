using System.Collections.Generic;
using System.Drawing;

namespace OOBC
{
    public class LineDrawer : ShapeDrawer
    {
        private const int LINE_POINTS_NUMBER = 2;

        public LineDrawer()
        {
            if (Points == null)
            {
                Points = new List<Point>(LINE_POINTS_NUMBER);
            }
        }

        public override Shape Draw()
        {
            if (Points.Count < LINE_POINTS_NUMBER)
            {
                throw new NotEnoughPointsForDrawingException();
            }
            return new Line(Points[0], Points[1]);
        }

    }
}