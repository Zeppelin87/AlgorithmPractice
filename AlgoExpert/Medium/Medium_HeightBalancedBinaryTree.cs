namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_HeightBalancedBinaryTree
    {
        public static void Run()
        {
            //var root = new BinaryTree(1);
            //root = new BinaryTree(1);
            //root.left = new BinaryTree(2);
            //root.right = new BinaryTree(3);
            //root.left.left = new BinaryTree(4);
            //root.left.right = new BinaryTree(5);
            //root.right.right = new BinaryTree(6);
            //root.left.right.left = new BinaryTree(7);
            //root.left.right.right = new BinaryTree(8);

            //// Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the BinaryTree).
            //// Space Complexity: O(h) -- (where 'h' is the height of the BinaryTree).
            //var result = Solution(root);
        }

        //private static bool Solution(BinaryTree tree)
        //{
        //    return GetTreeHeight(tree).balanced;
        //}

        //private static TreeInfo GetTreeHeight(BinaryTree tree)
        //{
        //    if (tree == null)
        //    {
        //        return new TreeInfo(-1, true);
        //    }

        //    TreeInfo leftTreeInfo = GetTreeHeight(tree.left);
        //    TreeInfo rightTreeInfo = GetTreeHeight(tree.right);

        //    int currentHeight = Math.Max(leftTreeInfo.height, rightTreeInfo.height) + 1;
        //    bool balanced = leftTreeInfo.balanced && rightTreeInfo.balanced && Math.Abs(leftTreeInfo.height - rightTreeInfo.height) <= 1;
        //    return new TreeInfo(currentHeight, balanced);
        //}
    }

    //public class BinaryTree
    //{
    //    public int value;
    //    public BinaryTree left;
    //    public BinaryTree right;

    //    public BinaryTree(int value)
    //    {
    //        this.value = value;
    //    }
    //}

    //public class TreeInfo
    //{
    //    public int height;
    //    public bool balanced;

    //    public TreeInfo(int height, bool balanced)
    //    {
    //        this.height = height;
    //        this.balanced = balanced;
    //    }
    //}
}
