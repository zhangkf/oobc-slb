using System;

namespace OOBC
{
    internal class ShapeDrawerFactory
    {
        public static ShapeDrawer CreateDrawer(string shapeType)
        {
            if (shapeType.Equals("line"))
            {
                return new LineDrawer();
            }
            throw new NotImplementedException();
        }
    }
}