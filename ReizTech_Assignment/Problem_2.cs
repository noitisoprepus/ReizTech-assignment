using System;

namespace ReizTech_Assignment
{
    class Problem_2
    {
        public static void Run()
        {
            // Made a tree out of Branch classes into a similar structure as the example in the assignment
            Branch root = new Branch();
            AddBranch(root, 2);

            AddBranch(root.branches[0], 1);
            AddBranch(root.branches[1], 3);

            AddBranch(root.branches[1].branches[0], 1);
            AddBranch(root.branches[1].branches[1], 2);

            AddBranch(root.branches[1].branches[1].branches[0], 1);

            // Gets the depth of the tree and outputs it to the console
            int depth = CalculateDepth(root);
            Console.WriteLine("The depth of the tree is {0}", depth);
        }

        // This function handles the creation of inner branches given the specified count
        static void AddBranch(Branch branch, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Branch newBranch = new Branch();
                branch.branches.Add(newBranch);
            }
        }

        // This function handles the calculation of the maximum depth count in a tree
        static int CalculateDepth(Branch branch)
        {
            int depth = 0;

            // Recursively calculates the depth of each child nodes to get the lowest node of the tree
            foreach (Branch node in branch.branches)
            {
                int innerDepth = CalculateDepth(node);
                depth = Math.Max(depth, innerDepth);
            }

            // Depth is added 1 more to include the current search node.
            return depth + 1;
        }
    }
}
