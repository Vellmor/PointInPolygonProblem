using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointInPolygonProblem;

namespace PointInPolygonProblemTests
{
    [TestClass]
    public class IsPointInPolygonTests
    {
        [TestMethod]
        public void PointInsidePolygon()
        {
            // Arrange
            PointF point1 = new PointF(4F, 2F);
            PointF[] polygon = new PointF[] {
                                                new PointF(0F, 0F),
                                                new PointF(0F, 8F),
                                                new PointF(4F, 4F),
                                                new PointF(9F, 7F),
                                                new PointF(13F, 0F),
                                            };
            // Act
            // Assert
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            Assert.AreEqual(true, answer);
        }
    }
}
