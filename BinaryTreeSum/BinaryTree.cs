namespace BinaryTreeSum
{
    public class BinaryTree
    {
        private int[] treeArray;

        public BinaryTree(int[] treeArray)
        {
            this.treeArray = treeArray;
        }

        public string MajorSum()
        {
            int rootIndex = 0;
            Console.WriteLine("Doing the sum on the left...");
            int leftSum = SumNodes(rootIndex * 2 + 1);
            Console.WriteLine("Doing the sum on the right...");
            int rightSum = SumNodes(rootIndex * 2 + 2);

            Console.WriteLine("Left Sum = " + leftSum);
            Console.WriteLine("Right Sum = " + rightSum);

            return leftSum > rightSum ? "Left" : leftSum < rightSum ? "Right" : "Equal";
        }

        private int SumNodes(int indice)
        {
            if (indice >= treeArray.Length || treeArray[indice] == -1)
            {
                return 0;
            }

            Console.WriteLine($"Node {indice}: {treeArray[indice]}");

            return treeArray[indice] + SumNodes(indice * 2 + 1) + SumNodes(indice * 2 + 2);
        }
    }
}
