using System.Drawing;

namespace PointInPolygonProblem
{
    public class IsPointInsideOrOutsidePolygon
    {
        public static bool IsPointInPolygon(PointF[] polygon, PointF point)

        {

            bool isInside = false;

            for (int i = 0, j = polygon.Length - 1; i < polygon.Length; j = i++)

            {

                if (((polygon[i].Y > point.Y) != (polygon[j].Y > point.Y)) &&

                (point.X < (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))

                {

                    isInside = !isInside;

                }

            }

            return isInside;

        }
    }
}

