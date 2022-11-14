namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_ValidateBST
    {
        public static void Run()
        {
            //var root = new BST(10);
            //root.left = new BST(5);
            //root.left.right = new BST(10);
            //root.right = new BST(15);
            //root.left = new BST(5);
            //root.left.left = new BST(2);
            //root.left.left.left = new BST(1);
            //root.left.right = new BST(5);
            //root.right = new BST(15);
            //root.right.left = new BST(13);
            //root.right.left.right = new BST(14);
            //root.right.right = new BST(22);

            // Worst:
            // Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the BST).
            // Space Complexity: O(d) -- (where 'd' is the depth (height) of the BST).
            //var result = Solution(root);
        }

        //private static bool Solution(BST tree)
        //{
        //    var isValid = ValidateBst(tree, int.MinValue, int.MaxValue);

        //    return isValid;
        //}

        //private static bool ValidateBst(BST tree, int minValue, int maxValue)
        //{
        //    if (tree.value < minValue || tree.value >= maxValue)
        //    {
        //        return false;
        //    }

        //    if (tree.left != null && ValidateBst(tree.left, minValue, tree.value))
        //    {
        //        return false;
        //    }

        //    if (tree.right != null && ValidateBst(tree.right, tree.value, maxValue))
        //    {
        //        return false;
        //    }


        //    return true;
        //}

        //private static List<int> TraverseInOrder(BST node, List<int> list)
        //{
        //    if (node.left != null)
        //    {
        //        TraverseInOrder(node.left, list);
        //    }

        //    list.Add(node.value);

        //    if (node.right != null)
        //    {
        //        TraverseInOrder(node.right, list);
        //    }

        //    return list;
        //}
    }

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
