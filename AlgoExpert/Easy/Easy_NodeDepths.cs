namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_NodeDepths
    {
        public static void Run()
        {
            // Time Complexity: O(n) -- Linear.
            // Space Complexity: 

            //var root = new BinaryTree(1);
            //root.left = new BinaryTree(2);
            //root.left.left = new BinaryTree(4);
            //root.left.left.left = new BinaryTree(8);
            //root.left.left.right = new BinaryTree(9);
            //root.left.right = new BinaryTree(5);
            //root.right = new BinaryTree(3);
            //root.right.left = new BinaryTree(6);
            //root.right.right = new BinaryTree(7);
            //int actual = Solution_NodeDepths(root);

            //var result2 = Solution_Two(root);
        }

        //private static int Solution_One(BinaryTree root)
        //{
        //    int sumOfDepths = 0;
        //    var stack = new Stack<Level>();
        //    stack.Push(new Level(root, 0));

        //    while (stack.Count > 0)
        //    {
        //        Level top = stack.Pop();

        //        BinaryTree node = top.root;
        //        int depth = top.depth;

        //        if (node == null)
        //        {
        //            continue;
        //        }

        //        sumOfDepths += depth;
        //        stack.Push(new Level(node.left, depth + 1));
        //        stack.Push(new Level(node.right, depth + 1));
        //    }

        //    return sumOfDepths;
        //}

        //private static int Solution_Two(BinaryTree root)
        //{
        //    return NodeDepthHelper(root, 0);
        //}

        //private static int NodeDepthHelper(BinaryTree root, int depth)
        //{
        //    if (root == null)
        //    {
        //        return 0;
        //    }

        //    return NodeDepthHelper(root.left, depth + 1) + NodeDepthHelper(root.right, depth + 1);
        //}

        //private static int Solution_NodeDepths(BinaryTree root)
        //{
        //    int total = CalculateNodeDepth(root, 0, 0);
        //    return total;
        //}

        //private static int CalculateNodeDepth(BinaryTree node, int currentDepth, int totalDepth)
        //{
        //    if (node == null)
        //    {
        //        return 0;
        //    }

        //    if (node.left == null && node.right == null)
        //    {
        //        return currentDepth;
        //    }

        //    var depthLeft = CalculateNodeDepth(node.left, currentDepth + 1, totalDepth);
        //    var depthRight = CalculateNodeDepth(node.right, currentDepth + 1, totalDepth);

        //    totalDepth = depthLeft + depthRight + currentDepth;
        //    return totalDepth;
        //}
    }

    //public class Level
    //{
    //    public BinaryTree root;
    //    public int depth;

    //    public Level(BinaryTree root, int depth)
    //    {
    //        this.root = root;
    //        this.depth = depth;
    //    }
    //}

    //public class BinaryTree
    //{
    //    public int value { get; set; }
    //    public BinaryTree left { get; set; }
    //    public BinaryTree right { get; set; }

    //    public BinaryTree(int value)
    //    {
    //        this.value = value;
    //        this.left = null;
    //        this.right = null;
    //    }
    //}
}
