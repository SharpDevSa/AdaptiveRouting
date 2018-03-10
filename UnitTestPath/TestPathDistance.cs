using System;
using AdaptiveRouting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPath
{
    [TestClass]
    public sealed class TestPathDistance
    {
        private readonly int[,] InputMap =
        {
            {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            {-1, 0,-1, 0, 0, 0,-1, 0, 0,-1},
            {-1, 0, 0, 0,-1, 0,-1,-1, 0,-1},
            {-1,-1,-1, 0,-1, 0, 0, 0, 0,-1},
            {-1, 0, 0, 0, 0, 0,-1,-1, 0,-1},
            {-1, 0,-1,-1,-1, 0,-1, 0, 0,-1},
            {-1, 0, 0,-1,-1, 0,-1,-1, 0,-1},
            {-1,-1, 0,-1, 0, 0, 0,-1, 0,-1},
            {-1, 0, 0, 0, 0,-1, 0, 0, 0,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}
        };

        //vert hor
        private PathFinder Finder;
        public TestPathDistance() {

            this.Finder = new PathFinder();
        }
        [TestCategory("Test point"), TestMethod]
        public void TestPosition1and1()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1,1));
            Assert.AreEqual(1, calculatedMap[1, 1]);
        }
        [TestCategory("Test point"), TestMethod]
        public void TestPosition2and2()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(3, calculatedMap[2, 2]);
        }
        [TestCategory("Test point"), TestMethod]
        public void TestPosition2and1()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(2, calculatedMap[2, 1]);
        }
        [TestCategory("Test point"), TestMethod]
        public void TestPosition8and8()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(15, calculatedMap[8, 8]);
        }

        [TestCategory("Test point"), TestMethod]
        public void TestPosition7and8()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(16, calculatedMap[7, 8]);
        }
        [TestCategory("Test point"), TestMethod]
        public void TestPosition6and8()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(15, calculatedMap[6, 8]);
        }
        [TestCategory("Test point"), TestMethod]
        public void TestPosition5and7()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(15, calculatedMap[5, 7]);
        }

        [TestCategory("Test point"), TestMethod]
        public void TestPosition5and5()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            Assert.AreEqual(9, calculatedMap[5, 5]);
        }

        [TestCategory("Exception"), TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestExceptionStartPoint()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(0, 0));
        }

        [TestCategory("Exception"), TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestExceptionMap()
        {
            var calculatedMap = this.Finder.GetMapDistance(new int[0,0], new Node(1, 1));
        }

        [TestMethod]
        public void TestDoubleIter()
        {
            var calculatedMap = this.Finder.GetMapDistance(this.InputMap, new Node(1, 1));
            var calculatedMap2 = this.Finder.GetMapDistance(calculatedMap, new Node(1, 1));
            Assert.AreEqual(calculatedMap, calculatedMap2);
        }
    }
}
