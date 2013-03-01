using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBC;
using FluentAssertions;

namespace OOBCTest
{
    [TestClass]
    public class DrawTriangleTest
    {
        [TestMethod]
        public void should_draw_triangle_with_3_points()
        {
            var expectedTriangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(2, 2));

            var triangleDrawer = new TriangleDrawer();
            triangleDrawer.AddPoint(new Point(0, 0), new Point(3, 0), new Point(2, 2));
            var triangle = triangleDrawer.Draw();

            triangle.Should().Be(expectedTriangle);
        }

        [TestMethod]
        public void should_draw_triangle_with_first_3_points()
        {
            var expectedTriangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(2, 2));

            var triangleDrawer = new TriangleDrawer();
            triangleDrawer.AddPoint(new Point(0, 0), new Point(3, 0), new Point(2, 2), new Point(4,4));
            var triangle = triangleDrawer.Draw();

            triangle.Should().Be(expectedTriangle);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughPointsForDrawingException))]
        public void should_throw_exception_when_drawing_triangle_with_less_than_3_points()
        {
            var triangleDrawer = new TriangleDrawer();
            triangleDrawer.AddPoint(new Point(0, 0), new Point(3, 0));
            triangleDrawer.Draw();
        }
    }
}
