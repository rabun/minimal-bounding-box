using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimalBoundingBox
{
    public static class Algorithm
    {
        /// <summary>
        /// Вычисляет баундинг бокс по массивы точек
        /// </summary>
        /// <param name="points">Массив точек</param>
        /// <returns></returns>
        public static Box BoundingBox(this List<Point> points)
        {
            double xmin = points.Min(p => p.X);
            double xmax = points.Max(p => p.X);
            double ymin = points.Min(p => p.Y);
            double ymax = points.Max(p => p.Y);

            return new Box
            {
                BottomRight = new Point { X = xmin, Y = ymax },
                TopRight = new Point { X = xmax, Y = ymax },
                BottomLeft = new Point { X = xmin, Y = ymin },
                TopLeft = new Point { X = xmax, Y = ymin }
            };
        }
    }
}
