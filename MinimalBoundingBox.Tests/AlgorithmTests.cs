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
            List<SimplePoint> points = new List<SimplePoint>();
            foreach (string line in lines)
            {
                string[] lp = line.Split('=', ';');
                points.Add(new SimplePoint { X = double.Parse(lp[1]), Y = double.Parse(lp[3]) });

            }

            SimpleBox box = points.BoundingBox();

            Assert.IsNotNull(box);
        }
    }
}
