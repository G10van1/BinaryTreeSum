﻿namespace BinaryTreeSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] treeArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
                                  , 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            BinaryTree binaryTree = new BinaryTree(treeArray);
            Console.WriteLine("The major side is on the " + binaryTree.MajorSum());
        }
    }
}