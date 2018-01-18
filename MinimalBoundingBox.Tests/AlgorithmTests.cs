using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinimalBoundingBox.Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void BoundingBoxTest()
        {
            string[] lines = File.ReadAllLines("Data/points1.txt");
            List<Point> points = new List<Point>();
            foreach (string line in lines)
            {
                string[] lp = line.Split('=', ';');
                points.Add(new Point { X = double.Parse(lp[1]), Y = double.Parse(lp[3]) });

            }

            Box box = points.BoundingBox();

            Assert.IsNotNull(box);
        }
    }
}
