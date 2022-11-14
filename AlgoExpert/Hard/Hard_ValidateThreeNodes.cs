namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_ValidateThreeNodes
    {
        public static void Run()
        {
            //var root = new BST(5);
            //root.left = new BST(2);
            //root.right = new BST(7);
            //root.left.left = new BST(1);
            //root.left.right = new BST(4);
            //root.right.left = new BST(6);
            //root.right.right = new BST(8);
            //root.left.left.left = new BST(0);
            //root.left.right.left = new BST(3);

            //var nodeOne = root;
            //var nodeTwo = root.left;
            //var nodeThree = root.left.right.left;

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n^2) -- Quadratic.
            // Where 'n' is the number of nodes in the BST.
            //var result = Solution_PreOrderTraverse(nodeOne, nodeTwo, nodeThree);

            // Time Complexity: O(h).
            // Space Complexity: O(h).
            // Where 'h' is the height of the BST.
            //var result2 = Solution_Recursive(nodeOne, nodeTwo, nodeThree);

            // Time Complexity: O(h).
            // Space Complexity: O(1).
            // Where 'h' is the height of the BST.
            //var result3 = Solution_WhileLoop(nodeOne, nodeTwo, nodeThree);
        }

        //private static bool Solution_WhileLoop(BST nodeOne, BST nodeTwo, BST nodeThree)
        //{
        //    if (IsDesc(nodeTwo, nodeOne))
        //    {
        //        return IsDesc(nodeThree, nodeTwo);
        //    }

        //    if (IsDesc(nodeTwo, nodeThree))
        //    {
        //        return IsDesc(nodeOne, nodeTwo);
        //    }

        //    return false;
        //}

        //private static bool IsDesc(BST node, BST target)
        //{
        //    while (node != null && node != target)
        //    {
        //        node = (target.value < node.value) ? node.left : node.right;
        //    }

        //    return node == target;
        //}

        //private static bool Solution_Recursive(BST nodeOne, BST nodeTwo, BST nodeThree)
        //{
        //    if (IsDescendant(nodeTwo, nodeOne))
        //    {
        //        return IsDescendant(nodeThree, nodeTwo);
        //    }

        //    if (IsDescendant(nodeTwo, nodeThree))
        //    {
        //        return IsDescendant(nodeOne, nodeTwo);
        //    }

        //    return false;
        //}

        //private static bool IsDescendant(BST node, BST target)
        //{
        //    if (node == null)
        //    {
        //        return false;
        //    }

        //    if (node == target)
        //    {
        //        return true;
        //    }

        //    return (target.value < node.value) ? IsDescendant(node.left, target) : IsDescendant(node.right, target);
        //}

        //private static bool Solution_PreOrderTraverse(BST nodeOne, BST nodeTwo, BST nodeThree)
        //{
        //    bool isValid = false;
        //    var leftOne = PreOrderTraverse(nodeOne.left, new List<int> { nodeOne.value });
        //    isValid = IsValid(leftOne, nodeOne.value, nodeTwo.value, nodeThree.value);

        //    if (!isValid)
        //    {
        //        var rightOne = PreOrderTraverse(nodeOne.right, new List<int> { nodeOne.value });
        //        isValid = IsValid(rightOne, nodeOne.value, nodeTwo.value, nodeThree.value);
        //    }

        //    if (!isValid)
        //    {
        //        var leftThree = PreOrderTraverse(nodeThree.left, new List<int> { nodeThree.value });
        //        isValid = IsValid(leftThree, nodeThree.value, nodeTwo.value, nodeOne.value);
        //    }

        //    if (!isValid)
        //    {
        //        var rightThree = PreOrderTraverse(nodeThree.right, new List<int> { nodeThree.value });
        //        isValid = IsValid(rightThree, nodeThree.value, nodeTwo.value, nodeOne.value);
        //    }

        //    return isValid;
        //}

        //private static List<int> PreOrderTraverse(BST tree, List<int> list)
        //{
        //    if (tree == null)
        //    {
        //        return list;
        //    }

        //    list.Add(tree.value);

        //    if (tree.left != null)
        //    {
        //        PreOrderTraverse(tree.left, list);
        //    }

        //    if (tree.right != null)
        //    {
        //        PreOrderTraverse(tree.right, list);
        //    }

        //    return list;
        //}

        //private static bool IsValid(List<int> list, int ancestor, int middle, int descendant)
        //{
        //    int ancestorIdx = int.MinValue;
        //    int middleIdx = int.MinValue;
        //    int descendantIdx = int.MinValue;

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] == ancestor)
        //        {
        //            ancestorIdx = i;
        //        }
        //        else if (list[i] == middle)
        //        {
        //            middleIdx = i;
        //        }
        //        else if (list[i] == descendant)
        //        {
        //            descendantIdx = i;
        //        }
        //    }

        //    if (ancestorIdx == int.MinValue || middleIdx == int.MinValue || descendantIdx == int.MinValue)
        //    {
        //        return false;
        //    }

        //    return middleIdx > ancestorIdx && middleIdx < descendantIdx;
        //}
    }

    //public class BST
    //{
    //    public int value;
    //    public BST left = null;
    //    public BST right = null;

    //    public BST(int value)
    //    {
    //        this.value = value;
    //    }
    //}
}
