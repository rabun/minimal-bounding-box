using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalBoundingBox
{
    /// <summary>
    /// Бокс (область)
    /// </summary>
    public class Box
    {
        /// <summary>
        /// Верхний левый угол
        /// </summary>
        public Point TopLeft { get; set; }
        /// <summary>
        /// Нижний левый угол
        /// </summary>
        public Point BottomLeft { get; set; }
        /// <summary>
        /// Верхний правый угол
        /// </summary>
        public Point TopRight { get; set; }
        /// <summary>
        /// Нижний правый угол
        /// </summary>
        public Point BottomRight { get; set; }
    }
}
