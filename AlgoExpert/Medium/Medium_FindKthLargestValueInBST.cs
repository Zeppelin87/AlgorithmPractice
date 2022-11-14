namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_FindKthLargestValueInBST
    {
        public static void Run()
        {
            //var root = new BST(15);
            //root.left = new BST(5);
            //root.left.left = new BST(2);
            //root.left.left.left = new BST(1);
            //root.left.left.right = new BST(3);
            //root.left.right = new BST(5);
            //root.right = new BST(20);
            //root.right.left = new BST(17);
            //root.right.right = new BST(22);
            //int k = 3;

            //// Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the BST).
            //// Space Complexity: O(n) -- Linear.
            //var result = Solution_TraverseInOrder(root, k);

            //// Time Complexity: O(h + k) -- (where 'h' is the height of the BST and 'k' is the input parameter.
            //// Space Complexity: O(h).
            //var result2 = Solution_Recursion(root, k);

            //// Time Complexity: O(h + k)--(where 'h' is the height of the BST and 'k' is the input parameter.
            //// Space Complexity: O(h).
            //var result3 = Solution_ConciseRecursion(root, k);
        }

        //private static int Solution_ConciseRecursion(BST tree, int k)
        //{
        //    var treeInfo = new TreeInformation(0, -1);
        //    ReverseInOrderTraverse(tree, k, treeInfo);

        //    return treeInfo.latestVisitedNodeValue;
        //}

        //private static void ReverseInOrderTraverse(BST node, int k, TreeInformation treeInfo)
        //{
        //    if (node == null || treeInfo.numberOfNodesVisited >= k)
        //    {
        //        return;
        //    }

        //    ReverseInOrderTraverse(node.right, k, treeInfo);

        //    if (treeInfo.numberOfNodesVisited < k)
        //    {
        //        treeInfo.numberOfNodesVisited++;
        //        treeInfo.latestVisitedNodeValue = node.value;
        //        ReverseInOrderTraverse(node.left, k, treeInfo);
        //    }
        //}

        //private static int Solution_Recursion(BST tree, int k)
        //{
        //    // Write your code here.
        //    var treeInfo = new TreeInfo(k, int.MinValue);
        //    FindLargestValue(tree, treeInfo);

        //    return treeInfo.result;
        //}

        //private static int Solution_TraverseInOrder(BST tree, int k)
        //{
        //    var array = InOrderTraverse(tree, new List<int>());

        //    int result = array[array.Count - k];

        //    return result;
        //}

        //private static void FindLargestValue(BST tree, TreeInfo treeInfo)
        //{
        //    if (treeInfo.k == 0)
        //    {
        //        return;
        //    }

        //    if (tree.right == null && tree.left == null)
        //    {
        //        treeInfo.k--;

        //        if (treeInfo.k == 0)
        //        {
        //            treeInfo.result = tree.value;
        //        }

        //        return;
        //    }

        //    if (tree.right != null)
        //    {
        //        FindLargestValue(tree.right, treeInfo);
        //    }

        //    if (treeInfo.k > 0)
        //    {
        //        treeInfo.k--;
        //    }

        //    if (treeInfo.k > 0 && tree.left != null)
        //    {
        //        FindLargestValue(tree.left, treeInfo);
        //    }
        //    else if (treeInfo.k == 0 && treeInfo.result == int.MinValue)
        //    {
        //        treeInfo.result = tree.value;
        //    }
        //}

        //private static List<int> InOrderTraverse(BST tree, List<int> array)
        //{
        //    if (tree.left != null)
        //    {
        //        InOrderTraverse(tree.left, array);
        //    }

        //    array.Add(tree.value);

        //    if (tree.right != null)
        //    {
        //        InOrderTraverse(tree.right, array);
        //    }

        //    return array;
        //}
    }

    //public class TreeInfo
    //{
    //    public int k;
    //    public int result;

    //    public TreeInfo(int k, int result)
    //    {
    //        this.k = k;
    //        this.result = result;
    //    }
    //}

    //public class TreeInformation
    //{
    //    public int numberOfNodesVisited;
    //    public int latestVisitedNodeValue;

    //    public TreeInformation(int numberOfNodesVisited, int latestVisitedNodeValue)
    //    {
    //        this.numberOfNodesVisited = numberOfNodesVisited;
    //        this.latestVisitedNodeValue = latestVisitedNodeValue;
    //    }
    //}

    //public class BST
    //{
    //    public int value;
    //    public BST left;
    //    public BST right;

    //    public BST(int value)
    //    {
    //        this.value = value;
    //    }
    //}
}
