﻿using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            
             // Tree example
            
             Tree<int> tree =
			new Tree<int>(7,
				new Tree<int>(19,
					new Tree<int>(1),
					new Tree<int>(12),
					new Tree<int>(31)),
				new Tree<int>(21),
				new Tree<int>(14,
					new Tree<int>(23),
					new Tree<int>(6))
			);
		Console.WriteLine("Depth-First Search (DFS) traversal (recursive):");
		tree.TraverseDFS();
		Console.WriteLine();
		Console.WriteLine("Breadth-First Search (BFS) traversal (with queue):");
		tree.TraverseBFS();
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Depth-First Search (DFS) traversal (with stack):");
		tree.TraverseDFSWithStack();
		Console.WriteLine();
             
        }
    }
}
