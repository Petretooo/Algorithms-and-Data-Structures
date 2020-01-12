using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {



            int INF = int.MaxValue;
            int[][] map =
            {
                      new int[] {3, 6}, // successors of vertice 0
                      new int[] {2, 3, 4, 5, 6}, // successors of vertice 1
                      new int[] {1, 4, 5}, // successors of vertice 2
                      new int[] {0, 1, 5}, // successors of vertice 3
                      new int[] {1, 2, 6}, // successors of vertice 4
                      new int[] {1, 2, 3}, // successors of vertice 5
                      new int[] {0, 1, 4}  // successors of vertice 6
            };



            MyGraph my = new MyGraph(map);


            my.Add(1,2, 1);
            my.TraverseDFS(0);
            Console.WriteLine();
            my.TraverseBFS(0);
            Console.WriteLine();










            


            Graph g = new Graph(new int[][] {
              new int[] {3, 6}, // successors of vertice 0
              new int[] {2, 3, 4, 5, 6}, // successors of vertice 1
              new int[] {1, 4, 5}, // successors of vertice 2
              new int[] {0, 1, 5}, // successors of vertice 3
              new int[] {1, 2, 6}, // successors of vertice 4
              new int[] {1, 2, 3}, // successors of vertice 5
              new int[] {0, 1, 4}  // successors of vertice 6
          });
            Console.Write("Breadth-First Search (BFS) traversal: ");
            g.TraverseBFS(0);
            Console.WriteLine();
            Console.Write("Depth-First Search (DFS) traversal (with stack): ");
            g.TraverseDFS(0);
            Console.WriteLine();
            Console.Write("Depth-First Search (DFS) traversal (recursive): ");
            bool[] visited = new bool[Graph.MaxNode];
            g.TraverseDFSRecursive(0, visited);
            Console.WriteLine();
            
        }
    }
}
