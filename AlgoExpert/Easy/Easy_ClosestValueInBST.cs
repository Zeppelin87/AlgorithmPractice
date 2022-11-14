namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_ClosestValueInBST
    {
        //public static void Run()
        //{
        //    var root = new BST(10);
        //    root.left = new BST(5);
        //    root.left.left = new BST(2);
        //    root.left.left.left = new BST(1);
        //    root.left.right = new BST(5);
        //    root.right = new BST(15);
        //    root.right.left = new BST(13);
        //    root.right.left.right = new BST(14);
        //    root.right.right = new BST(22);

        //    int target = 12;

        //    // Time Complexity:
        //    //  - Avg: O(log n) -- Logarithmic.
        //    //  - Worst: O(n) -- Linear.
        //    // Space Complexity:
        //    //  - Avg: O(1) -- Constant.
        //    //  - Worst: O(1) -- Constant.
        //    var result = Solution_Iterative(root, target);

        //    // Time Complexity:
        //    //  - Avg: O(log n) -- Logarithmic.
        //    //  - Worst: O(log n) -- Logarithmic.
        //    // Space Complexity:
        //    //  - Avg: O(n) -- Constant.
        //    //  - Worst: O(n) -- Constant.
        //    var result2 = Solution_Recursive(root, target);
        //}

        //private static int Solution_Iterative(BST tree, int target)
        //{
        //    return FindClosestValue(tree, target, tree.value);
        //}

        //private static int Solution_Recursive(BST tree, int target)
        //{
        //    return FindClosestValueRecursively(tree, target, tree.value);
        //}

        //private static int FindClosestValueRecursively(BST tree, int target, int closest)
        //{
        //    if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
        //    {
        //        closest = tree.value;
        //    }

        //    if (target > tree.value && tree.right != null)
        //    {
        //        return FindClosestValueRecursively(tree.right, target, closest);
        //    }
        //    else if (target < tree.value && tree.left != null)
        //    {
        //        return FindClosestValueRecursively(tree.left, target, closest);
        //    }
        //    else
        //    {
        //        return closest;
        //    }
        //}

        //private static int FindClosestValue(BST tree, int target, int closest)
        //{
        //    BST currentNode = tree;

        //    while (currentNode != null)
        //    {
        //        if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
        //        {
        //            closest = currentNode.value;
        //        }

        //        if (target > currentNode.value)
        //        {
        //            currentNode = currentNode.right;
        //        }
        //        else if (target < currentNode.value)
        //        {
        //            currentNode = currentNode.left;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    return closest;
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

    //public class Node
    //{
    //    public int value { get; set; }
    //    public Node left { get; set; }
    //    public Node right { get; set; }

    //    public Node(int value)
    //    {
    //        this.value = value;
    //        left = null;
    //        right = null;
    //    }
    //}

    //public class BST
    //{
    //    public Node root { get; set; }

    //    public BST()
    //    {
    //        this.root = null;
    //    }

    //    public void Insert(int value)
    //    {
    //        var newNode = new Node(value);

    //        if (this.root == null)
    //        {
    //            this.root = newNode;
    //            return;
    //        }

    //        var currentNode = this.root;

    //        while (true)
    //        {
    //            if (newNode.value > currentNode.value)
    //            {
    //                // Go right.
    //                if (currentNode.right == null)
    //                {
    //                    currentNode.right = newNode;
    //                    return;
    //                }

    //                currentNode = currentNode.right;
    //            }
    //            else
    //            {
    //                // Go left.
    //                if (currentNode.left == null)
    //                {
    //                    currentNode.left = newNode;
    //                    return;
    //                }

    //                currentNode = currentNode.left;
    //            }
    //        }
    //    }
    //}
}
