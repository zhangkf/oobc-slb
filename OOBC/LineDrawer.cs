using System.Collections.Generic;
using System.Drawing;

namespace OOBC
{
    public class LineDrawer : ShapeDrawer
    {
        private List<Point> points;

        public Line Draw(Point start, Point end)
        {
            AddPoint(start);
            AddPoint(end);
            return (Line) Draw();
        }

        public override void AddPoint(string point)
        {
            Point _point = PointParser.ToPoint(point);
            AddPoint(_point);
        }

        private void AddPoint(Point point)
        {
            if (this.points == null)
            {
                this.points = new List<Point>(2);
            }

            if (this.points.Count < this.points.Capacity)
            {
                this.points.Add(point);
            }
        }

        public override Shape Draw()
        {
            return new Line(points[0], points[1]);
        }
    }
}