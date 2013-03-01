using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBC;

namespace OOBCTest
{
    [TestClass]
    public class DrawLineTest
    {
        [TestMethod]
        public void should_draw_line_with_2_points()
        {
            var expectedLine = new Line(new Point(0, 0), new Point(1, 1));

            var lineDrawer = new LineDrawer();
            lineDrawer.AddPoint(new Point(0,0), new Point(1,1));
            var line = lineDrawer.Draw();

            Assert.AreEqual(expectedLine, line);
        }

        [TestMethod]
        public void should_draw_line_with_only_first_2_points()
        {
            var expectedLine = new Line(new Point(0, 0), new Point(1, 1));

            var lineDrawer = new LineDrawer();
            lineDrawer.AddPoint(new Point(0,0), new Point(1,1), new Point(2,2));
            var line = lineDrawer.Draw();

            Assert.AreEqual(expectedLine, line);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughPointsForDrawingException))]
        public void should_throw_exception_when_drawing_line_with_less_than_2_points()
        {
            var lineDrawer = new LineDrawer();
            lineDrawer.AddPoint(new Point(0,0));
            lineDrawer.Draw();
        }
    }
}
