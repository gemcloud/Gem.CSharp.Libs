using Algorithms;
using NUnit.Framework;

namespace NUnitTestAlgorithms
{
    public class RatInMazeTest
    {
        private int N;
        private int[,] maze;

        [SetUp]
        public void Setup()
        {
            N = 5;
            maze = new int[,] {
                { 1, 0, 1, 1,1 },
                { 1, 1, 1, 0,1 },
                { 1, 0,0, 1, 1 },
                { 1, 0, 0, 1,0 },
                { 1, 0,0, 1, 1 }
            };

        }

        [Test]
        public void TestRateInMaze1()
        {
            // test print
            RatInMaze.Print(maze, N, "  print input data  ");
            RatInMaze r = new RatInMaze(N);
            r.SolveMaze(maze, N);
            Assert.Pass();
        }
    }
}
