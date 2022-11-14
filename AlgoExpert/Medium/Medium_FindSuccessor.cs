namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_FindSuccessor
    {
        public static void Run()
        {
            //    var root = new BinaryTree(1);
            //    root.left = new BinaryTree(2);
            //    root.left.parent = root;
            //    root.right = new BinaryTree(3);
            //    root.right.parent = root;
            //    root.left.left = new BinaryTree(4);
            //    root.left.left.parent = root.left;
            //    root.left.right = new BinaryTree(5);
            //    root.left.right.parent = root.left;
            //    root.left.left.left = new BinaryTree(6);
            //    root.left.left.left.parent = root.left.left;
            //    var node = root.left.right;

            //    // Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the BinaryTree).
            //    // Space Complexity: O(n) -- Linear.
            //    var result = Solution_FindSuccessor(root, node);

            //    // Time Complexity: O(h) -- Linear (where 'h' is the height of the tree).
            //    // Space Complexity: O(1) -- Constant.
            //    var result2 = Solution_NoTraverse(root, node);
            //}

            //private static BinaryTree Solution_NoTraverse(BinaryTree tree, BinaryTree node)
            //{
            //    if (node.right != null)
            //    {
            //        return GetLeftmostChild(node.right);
            //    }

            //    return GetRightmostParent(node);
            //}

            //private static BinaryTree GetLeftmostChild(BinaryTree node)
            //{
            //    var currentNode = node;

            //    while (currentNode.left != null)
            //    {
            //        currentNode = currentNode.left;
            //    }

            //    return currentNode;
            //}

            //private static BinaryTree GetRightmostParent(BinaryTree node)
            //{
            //    var currentNode = node;

            //    while (currentNode.parent != null && currentNode.parent.right == currentNode)
            //    {
            //        currentNode = currentNode.parent;
            //    }

            //    return currentNode.parent;
            //}

            //private static BinaryTree Solution_FindSuccessor(BinaryTree tree, BinaryTree node)
            //{
            //    var list = TraverseInOrder(tree, new List<BinaryTree>());

            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (node.value == list[i].value && i < list.Count - 1)
            //        {
            //            return list[i + 1];
            //        }
            //    }

            //    return null;
            //}

            //private static List<BinaryTree> TraverseInOrder(BinaryTree tree, List<BinaryTree> list)
            //{
            //    if (tree.left != null)
            //    {
            //        TraverseInOrder(tree.left, list);
            //    }

            //    list.Add(tree);

            //    if (tree.right != null)
            //    {
            //        TraverseInOrder(tree.right, list);
            //    }

            //    return list;
        }
    }

    //public class BinaryTree
    //{
    //    public int value;
    //    public BinaryTree left = null;
    //    public BinaryTree right = null;
    //    public BinaryTree parent = null;

    //    public BinaryTree(int value)
    //    {
    //        this.value = value;
    //    }
    //}
}
