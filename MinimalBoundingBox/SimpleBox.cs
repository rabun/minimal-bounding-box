using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalBoundingBox
{
    /// <summary>
    /// Бокс (область)
    /// </summary>
    public class SimpleBox
    {
        /// <summary>
        /// Верхний левый угол
        /// </summary>
        public SimplePoint TopLeft { get; set; }
        /// <summary>
        /// Нижний левый угол
        /// </summary>
        public SimplePoint BottomLeft { get; set; }
        /// <summary>
        /// Верхний правый угол
        /// </summary>
        public SimplePoint TopRight { get; set; }
        /// <summary>
        /// Нижний правый угол
        /// </summary>
        public SimplePoint BottomRight { get; set; }
    }
}
