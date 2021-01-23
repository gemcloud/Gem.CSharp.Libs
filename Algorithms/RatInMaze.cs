using System;

namespace Algorithms
{
    public class RatInMaze
    {

        public int[,] solution;

        //initialize the solution matrix in constructor.
        public RatInMaze(int N)
        {
            solution = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    solution[i, j] = 0;
                }
            }
        }

        public void SolveMaze(int[,] maze, int N)
        {
            if (FindPath(maze, 0, 0, N, "down"))
            {
                Print(solution, N, "   Print Result   ");
            }
            else
            {
                Console.WriteLine("NO PATH FOUND");
            }

        }

        public bool FindPath(int[,] maze, int x, int y, int N, string direction)
        {
            // check if maze[x][y] is feasible to move
            if (x == N - 1 && y == N - 1)
            {//we have reached
                solution[x, y] = 1;
                return true;
            }
            if (IsSafeToGo(maze, x, y, N))
            {
                // move to maze[x][y]
                solution[x, y] = 1;
                // now rat has four options, either go right OR go down or left or go up
                if (direction != "up" && FindPath(maze, x + 1, y, N, "down"))
                { //go down
                    return true;
                }
                //else go down
                if (direction != "left" && FindPath(maze, x, y + 1, N, "right"))
                { //go right
                    return true;
                }
                if (direction != "down" && FindPath(maze, x - 1, y, N, "up"))
                { //go up
                    return true;
                }
                if (direction != "right" && FindPath(maze, x, y - 1, N, "left"))
                { //go left
                    return true;
                }
                //if none of the options work out BACKTRACK undo the move
                solution[x, y] = 0;
                return false;
            }
            return false;
        }

        // this function will check if mouse can move to this cell
        public bool IsSafeToGo(int[,] maze, int x, int y, int N)
        {
            // check if x and y are in limits and cell is not blocked
            if (x >= 0 && y >= 0 && x < N && y < N && maze[x, y] != 0)
            {
                return true;
            }
            return false;
        }

        public static void Print(int[,] solution, int N, string comments = "")
        {
            Console.WriteLine(string.Format("----------------------Start : {0}-----------------------", comments));
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(" " + solution[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Format("----------------------End : {0}-----------------------", comments));
        }

    }
}
