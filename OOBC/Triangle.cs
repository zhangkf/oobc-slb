using System.Drawing;

namespace OOBC
{
    public class Triangle : Shape
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            this._point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        protected bool Equals(Triangle other)
        {
            return _point1.Equals(other._point1) && _point2.Equals(other._point2) && _point3.Equals(other._point3);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Triangle) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _point1.GetHashCode();
                hashCode = (hashCode*397) ^ _point2.GetHashCode();
                hashCode = (hashCode*397) ^ _point3.GetHashCode();
                return hashCode;
            }
        }
    }
}