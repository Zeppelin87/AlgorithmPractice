namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_BSTConstruction
    {
        public static void Run()
        {
            //var root = new BST(10);
            //root.left = new BST(5);
            //root.left.left = new BST(2);
            //root.left.left.left = new BST(1);
            //root.left.right = new BST(5);
            //root.right = new BST(15);
            //root.right.left = new BST(13);
            //root.right.left.right = new BST(14);
            //root.right.right = new BST(22);

            //root.Insert(12);
            //var contains12 = root.Contains(12);
            //var contains11 = root.Contains(11);

            //root.Remove(10);

            //var shouldBeTrue = root.Contains(15);

            // Average Case:
            // Time Complexity: O(log(n)) -- Logarithmic (where 'n' is the size total number of nodes in the BST).
            // Space Complexity: O(1) -- Constant.

            // Worst Case:
            // Time Complexity: O(n) -- Linear (where 'n' is the size total number of nodes in the BST).
            // Space Complexity: O(1) -- Constant.
        }
    }

    //public class BST
    //{
    //public int value;
    //public BST left;
    //public BST right;

    //public BST(int value)
    //{
    //    this.value = value;
    //}

    //public BST Insert(int value)
    //{
    //    var newNode = new BST(value);
    //    var currentNode = this;

    //    while (currentNode != null)
    //    {
    //        if (newNode.value > currentNode.value)
    //        {
    //            // Go right.
    //            if (currentNode.right == null)
    //            {
    //                currentNode.right = newNode;
    //                break;
    //            }
    //            else
    //            {
    //                currentNode = currentNode.right;
    //            }

    //        }
    //        else if (newNode.value < currentNode.value)
    //        {
    //            // Go left.
    //            if (currentNode.left == null)
    //            {
    //                currentNode.left = newNode;
    //                break;
    //            }
    //            else
    //            {
    //                currentNode = currentNode.left;
    //            }
    //        }
    //    }

    //    return this;
    //}

    //public bool Contains(int value)
    //{
    //    var currentNode = this;

    //    while (currentNode != null)
    //    {
    //        if (value == currentNode.value)
    //        {
    //            return true;
    //        }
    //        else if (value > currentNode.value)
    //        {
    //            currentNode = currentNode.right;
    //        }
    //        else if (value < currentNode.value)
    //        {
    //            currentNode = currentNode.left;
    //        }
    //    }

    //    return false;
    //}

    //public BST Remove(int value)
    //{
    //    if (this.left == null && this.right == null)
    //    {
    //        return this;
    //    }

    //    // Search for node to remove & its parent.
    //    var nodeToRemove = this;
    //    BST parentNode = null;

    //    while (value != nodeToRemove.value)
    //    {
    //        parentNode = nodeToRemove;

    //        if (value > nodeToRemove.value)
    //        {
    //            nodeToRemove = nodeToRemove.right;
    //        }
    //        else if (value < nodeToRemove.value)
    //        {
    //            nodeToRemove = nodeToRemove.left;
    //        }
    //    }

    //    BST replacementNode = null;

    //    // We have a right child.
    //    if (nodeToRemove.right != null)
    //    {
    //        replacementNode = nodeToRemove.right;

    //        // We don't need to find predecessor, we already have it.
    //        if (replacementNode.left == null)
    //        {
    //            replacementNode.left = nodeToRemove.left;
    //        }
    //        else
    //        {
    //            // Find the nodeToRemove's predecessor.
    //            var replacementParentNode = nodeToRemove;
    //            while (replacementNode.left != null)
    //            {
    //                replacementParentNode = replacementNode;
    //                replacementNode = replacementNode.left;
    //            }

    //            // Remove the parentPredecessor's reference to the predecessor.
    //            replacementParentNode.left = null;

    //            // Set the predecessor's .left & .right values to match the nodeToRemove's values.
    //            replacementNode.left = nodeToRemove.left;
    //            replacementNode.right = nodeToRemove.right;
    //        }
    //    }
    //    else if (nodeToRemove.left != null)
    //    {
    //        // We only have a left node.
    //        replacementNode = nodeToRemove.left;
    //    }

    //    if (parentNode == null)
    //    {
    //        this.value = replacementNode.value;
    //        this.left = replacementNode.left;
    //        this.right = replacementNode.right;
    //    }
    //    else if (parentNode.left == nodeToRemove)
    //    {
    //        parentNode.left = replacementNode;
    //    }
    //    else if (parentNode.right == nodeToRemove)
    //    {
    //        parentNode.right = replacementNode;
    //    }

    //    return this;
    //}
    //}
}
