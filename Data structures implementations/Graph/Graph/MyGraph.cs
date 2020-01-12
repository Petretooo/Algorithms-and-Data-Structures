using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class MyGraph
    {
        private int[][] matrix;
        public MyGraph(int[][] matrix)
        {
            this.matrix = matrix;
        }

        public void Add(int v, int e, int value)
        {
            if (v < matrix.GetLength(0))
            {
                matrix[v][e] = value;
            }
        }
        public void Remove(int v, int e)
        {
            matrix[v][e] = 0;
        }
        public void TraverseBFS(int node)
        {
            bool[] visited = new bool[matrix.GetLength(0)];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            visited[node] = true;
            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                Console.Write("{0} ", currentNode);
                foreach (int childNode in matrix[currentNode])
                {
                    if (!visited[childNode])
                    {
                        queue.Enqueue(childNode);
                        visited[childNode] = true;
                    }
                }
            }
        }
        public void TraverseDFS(int node)
        {
            bool[] visited = new bool[matrix.GetLength(0)];
            Stack<int> stack = new Stack<int>();
            stack.Push(node);
            visited[node] = true;
            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                Console.Write("{0} ", currentNode);
                foreach (int childNode in matrix[currentNode])
                {
                    if (!visited[childNode])
                    {
                        stack.Push(childNode);
                        visited[childNode] = true;
                    }
                }
            }
        }











        /*
        private bool[] isTreversed;
        int INF = int.MaxValue;
        public void FindShortestPath(int v)
        {
            int N = matrix.GetLength(0);
            int[] distances = new int[N];
            for (int i = 0; i < N; i++)
            {
                distances[i] = matrix[v][i];
            }

            isTreversed[v] = true;

            while (true)
            {
                int nextTreverse = -1;
                int min = int.MaxValue;
                for (int i = 0; i < N; i++)
                {
                    if (isTreversed[i] == false && min > distances[i])
                    {
                        nextTreverse = i;
                        min = distances[i];
                    }
                }

                if (nextTreverse == -1)
                {
                    break;
                }

                isTreversed[nextTreverse] = true;

                for (int i = 0; i < N; i++)
                {
                    if (matrix[nextTreverse][i] != INF
                        && distances[i] > distances[nextTreverse] + matrix[nextTreverse][i])
                    {
                        distances[i] = distances[nextTreverse] + matrix[nextTreverse][i];
                    }
                }
            }

            Console.WriteLine(String.Join(",", distances));
        }
        */
    }
}
