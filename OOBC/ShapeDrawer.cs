using System.Collections.Generic;
using System.Drawing;

namespace OOBC
{
    public abstract class ShapeDrawer
    {
        protected List<Point> Points;

        public abstract Shape Draw();

        public virtual void AddPoint(string point)
        {
            AddPoint(PointParser.ToPoint(point));
        }

        public virtual void AddPoint(params Point[] points)
        {
            if (Points.Count < Points.Capacity)
            {
                Points.AddRange(points);
            }
        }
    }
}