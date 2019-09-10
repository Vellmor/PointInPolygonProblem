using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointInPolygonProblem;
using System.Drawing;

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
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void PointOutsidePolygonRight()
        {
            // Arrange
            PointF point1 = new PointF(14F, 2F);
            PointF[] polygon = new PointF[] {
                                                new PointF(0F, 0F),
                                                new PointF(0F, 8F),
                                                new PointF(4F, 4F),
                                                new PointF(9F, 7F),
                                                new PointF(13F, 0F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void PointOutsidePolygonLeft()
        {
            // Arrange
            PointF point1 = new PointF(-1F, 2F);
            PointF[] polygon = new PointF[] {
                                                new PointF(0F, 0F),
                                                new PointF(0F, 8F),
                                                new PointF(4F, 4F),
                                                new PointF(9F, 7F),
                                                new PointF(13F, 0F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void PointOnLeftBorderOfPolygon()
        {
            // Arrange
            PointF point1 = new PointF(0F, 2F);
            PointF[] polygon = new PointF[] {
                                                new PointF(0F, 0F),
                                                new PointF(0F, 8F),
                                                new PointF(4F, 4F),
                                                new PointF(9F, 7F),
                                                new PointF(13F, 0F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void PointOnBottomBorderOfPolygon()
        {
            // Arrange
            PointF point1 = new PointF(4F, 0F);
            PointF[] polygon = new PointF[] {
                                                new PointF(0F, 0F),
                                                new PointF(0F, 8F),
                                                new PointF(4F, 4F),
                                                new PointF(9F, 7F),
                                                new PointF(13F, 0F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void PointOnVertexOfPolygon()
        {
            // Arrange
            PointF point1 = new PointF(4F, 4F);
            PointF[] polygon = new PointF[] {
                                                new PointF(0F, 0F),
                                                new PointF(0F, 8F),
                                                new PointF(4F, 4F),
                                                new PointF(9F, 7F),
                                                new PointF(13F, 0F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void PointInsidePolygonWithSelfIntersections()
        {
            // Arrange
            PointF point1 = new PointF(-2F, 1F);
            PointF[] polygon = new PointF[] {
                                                new PointF(3F, 0F),
                                                new PointF(2F, -1F),
                                                new PointF(1F, 3F),
                                                new PointF(-3F, 0F),
                                                new PointF(-2F, 2F),
                                                new PointF(-1F, 0F),
                                                new PointF(0F, 4F),
                                                new PointF(1F, 0F),
                                                new PointF(2F, 2F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void PointOutsidePolygonWithSelfIntersections()
        {
            // Arrange
            PointF point1 = new PointF(-1F, 2F);
            PointF[] polygon = new PointF[] {
                                                new PointF(3F, 0F),
                                                new PointF(2F, -1F),
                                                new PointF(1F, 3F),
                                                new PointF(-3F, 0F),
                                                new PointF(-2F, 2F),
                                                new PointF(-1F, 0F),
                                                new PointF(0F, 4F),
                                                new PointF(1F, 0F),
                                                new PointF(2F, 2F),
                                            };
            // Act
            bool answer = IsPointInsideOrOutsidePolygon.IsPointInPolygon(polygon, point1);
            // Assert
            Assert.AreEqual(false, answer);
        }
    }
}
