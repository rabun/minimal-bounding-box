using System.Collections.Generic;
using System.Linq;

namespace MinimalBoundingBox
{
    /// <summary>
    /// Алгоритм
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// Вычисляет баундинг бокс по массивы точек
        /// </summary>
        /// <param name="points">Массив точек</param>
        /// <returns></returns>
        public static SimpleBox BoundingBox(this List<SimplePoint> points)
        {
            double xmin = points.Min(p => p.X);
            double xmax = points.Max(p => p.X);
            double ymin = points.Min(p => p.Y);
            double ymax = points.Max(p => p.Y);

            return new SimpleBox
            {
                BottomRight = new SimplePoint { X = xmin, Y = ymax },
                TopRight = new SimplePoint { X = xmax, Y = ymax },
                BottomLeft = new SimplePoint { X = xmin, Y = ymin },
                TopLeft = new SimplePoint { X = xmax, Y = ymin }
            };
        }
    }
}
