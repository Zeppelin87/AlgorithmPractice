namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_MaxPathSumInBinaryTree
    {
        public static void Run()
        {
            //var tree = new BinaryTree(1);
            //tree.insert(new int[] { 2, 3, 4, 5, 6, 7 }, 0);

            //var tree = new BinaryTree(1);
            //tree.left = new BinaryTree(2);
            //tree.right = new BinaryTree(-1);

            //var tree = new BinaryTree(1);
            //tree.right = new BinaryTree(2);
            //tree.left = new BinaryTree(3);
            //tree.left.left = new BinaryTree(7);
            //tree.left.left.left = new BinaryTree(8);
            //tree.left.left.left.left = new BinaryTree(9);
            //tree.left.right = new BinaryTree(4);
            //tree.left.right.right = new BinaryTree(5);
            //tree.left.right.right.right = new BinaryTree(6);

            //tree.right = new BinaryTree(-1);
            //tree.left = new BinaryTree(2);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(h).
            // Where: 'n' is the number of nodes in the BinaryTree and 'h' is the height of the BinaryTree.
            //var result = Solution(tree);
        }

        //private static int Solution(BinaryTree tree)
        //{
        //    if (tree.left == null && tree.right == null)
        //    {
        //        return tree.value;
        //    }

        //    return FindMaxPathSum(tree).currentTotal;
        //}

        //private static TreeInfo FindMaxPathSum(BinaryTree tree)
        //{
        //    if (tree == null)
        //    {
        //        return new TreeInfo(int.MinValue, int.MinValue);
        //    }

        //    TreeInfo leftTreeInfo = FindMaxPathSum(tree.left);
        //    TreeInfo rightTreeInfo = FindMaxPathSum(tree.right);


        //    int pathSum = 0; 

        //    if (leftTreeInfo.pathSum == int.MinValue && rightTreeInfo.pathSum == int.MinValue)
        //    {
        //        pathSum = tree.value;
        //    }
        //    else
        //    {
        //        pathSum = Math.Max(leftTreeInfo.pathSum, rightTreeInfo.pathSum) + tree.value;
        //    }

        //    int currentTotal = tree.value;

        //    if (leftTreeInfo.pathSum != int.MinValue && leftTreeInfo.pathSum > 0)
        //    {
        //        currentTotal += leftTreeInfo.pathSum;
        //    }

        //    if (rightTreeInfo.pathSum != int.MinValue && rightTreeInfo.pathSum > 0)
        //    {
        //        currentTotal += rightTreeInfo.pathSum;
        //    }

        //    currentTotal = (currentTotal > Math.Max(leftTreeInfo.currentTotal, rightTreeInfo.currentTotal)) ? currentTotal : Math.Max(leftTreeInfo.currentTotal, rightTreeInfo.currentTotal);

        //    return new TreeInfo(pathSum, currentTotal);
        //}
    }

    //public class TreeInfo
    //{
    //    public int pathSum;
    //    public int currentTotal;

    //    public TreeInfo(int pathSum, int currentTotal)
    //    {
    //        this.pathSum = pathSum;
    //        this.currentTotal = currentTotal;
    //    }
    //}

    //public class BinaryTree
    //{
    //    public int value;
    //    public BinaryTree left;
    //    public BinaryTree right;

    //    public BinaryTree(int value)
    //    {
    //        this.value = value;
    //    }

    //    public void insert(int[] values, int i)
    //    {
    //        if (i >= values.Length)
    //        {
    //            return;
    //        }

    //        var queue = new List<BinaryTree>();
    //        queue.Add(this);
    //        var index = 0;

    //        while (index < queue.Count)
    //        {
    //            BinaryTree current = queue[index];
    //            index += 1;

    //            if (current.left == null)
    //            {
    //                current.left = new BinaryTree(values[i]);
    //                break;
    //            }

    //            queue.Add(current.left);

    //            if (current.right == null)
    //            {
    //                current.right = new BinaryTree(values[i]);
    //                break;
    //            }

    //            queue.Add(current.right);
    //        }

    //        insert(values, i + 1);
    //    }
    //}
}
