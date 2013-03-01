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
            var line = lineDrawer.Draw(new Point(0, 0), new Point(1, 1));

            Assert.AreEqual(expectedLine, line);
        }
    }
}
