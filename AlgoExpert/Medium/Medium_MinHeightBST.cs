namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MinHeightBST
    {
        public static void Run()
        {
            var array = new List<int>() { 1, 2, 5, 7, 10, 13, 14, 15, 22, 28, 32, 36 };

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the array).
            // Space Complexity: O(n) -- Linear.
            //var tree = Solution(array);
        }

        //private static BST Solution(List<int> array)
        //{
        //    BST tree = SortedArrayToBST(array, 0, array.Count - 1);
        //    var preOrder = PreOrderTraverse(tree, new List<int>());
        //    return tree;
        //}

        //private static BST SortedArrayToBST(List<int> array, int lo, int hi)
        //{
        //    if (lo > hi)
        //    {
        //        return null;
        //    }

        //    int mid = (lo + hi) / 2;
        //    var tree = new BST(array[mid]);

        //    tree.left = SortedArrayToBST(array, lo, mid - 1);

        //    tree.right = SortedArrayToBST(array, mid + 1, hi);

        //    return tree;
        //}

        //private static List<int> PreOrderTraverse(BST tree, List<int> arr)
        //{
        //    arr.Add(tree.value);

        //    if (tree.left != null)
        //    {
        //        PreOrderTraverse(tree.left, arr);
        //    }

        //    if (tree.right != null)
        //    {
        //        PreOrderTraverse(tree.right, arr);
        //    }

        //    return arr;
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
    //        this.left = null;
    //        this.right = null;
    //    }

    //    public void insert(int value)
    //    {
    //        if (value < this.value)
    //        {
    //            if (left == null)
    //            {
    //                left = new BST(value);
    //            }
    //            else
    //            {
    //                left.insert(value);
    //            }    
    //        }
    //        else
    //        {
    //            if (right == null)
    //            {
    //                right = new BST(value);
    //            }
    //            else
    //            {
    //                right.insert(value);
    //            }
    //        }
    //    }
    //}
}
