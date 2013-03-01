using System;

namespace OOBC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input shape type:");
            string shapeType = Console.ReadLine();
            ShapeDrawer shapeDrawer = ShapeDrawerFactory.CreateDrawer(shapeType);

            while (true)
            {
                Console.WriteLine("input point for drawing this shape:");
                string point = Console.ReadLine();
                if (point.Length > 0)
                {
                    shapeDrawer.AddPoint(point);
                }
                else
                {
                    break;
                }
            }

            Shape shape = shapeDrawer.Draw();
            Console.WriteLine(shape);
            Console.ReadLine();
        }
    }
}
