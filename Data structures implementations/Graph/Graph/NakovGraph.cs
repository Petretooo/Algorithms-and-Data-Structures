using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class NakovGraph
    {
        int[,] arr;

        public NakovGraph(int[,] arr)
        {
            this.arr = arr;
        }

        public void AddEdge(int i, int j)
        {
            arr[i, j] = 1;
        }

        public void RemoveEdge(int i, int j)
        {
            arr[i, j] = 0;
        }

        public bool hasEdge(int i, int j)
        {
            return arr[i, j] == 1;
        }

        public IList<int> GetSuccessers(int i)
        {
            IList<int> successors = new List<int>();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == 1)
                {
                    successors.Add(j);
                }
            }
            return successors;
            
        }
    }
}
