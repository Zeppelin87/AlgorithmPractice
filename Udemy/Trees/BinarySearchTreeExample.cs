namespace AlgorithmPractice.Udemy.Trees
{
    public static class BinarySearchTreeExample
    {
        public static void Run()
        {
            var bst = new BST();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            bst.PrintTree(bst.Root);
        }
    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            this.Left = null;
            this.Right = null;
            this.Value = value;
        }
    }

    public class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            this.Root = null;
        }

        public void Insert(int value)
        {
            var newNode = new Node(value);

            // If the tree is empty -> make the root node our newNode.
            if (this.Root == null)
            {
                this.Root = newNode;
                return;
            }

            var currentNode = this.Root;

            while (true)
            {
                if (currentNode.Value > value)
                {
                    // Place the newNode somewhere in left child subtree.
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        return;
                    }

                    currentNode = currentNode.Left;
                }
                else
                {
                    // Place the newNode somewhere in the right child subtree.
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        return;
                    }

                    currentNode = currentNode.Right;
                }
            }
        }

        public Node Lookup(int value)
        {
            if (this.Root == null)
            {
                return null;
            }

            var currentNode = this.Root;

            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    return currentNode;
                }
            }

            return null;
        }

        public void Remove(int value)
        {
            if (this.Root == null)
            {
                return;
            }

            var nodeToRemove = this.Root;
            Node parentNode = null;

            // Searching for the node to remove and its parent.
            while (nodeToRemove.Value != value)
            {
                parentNode = nodeToRemove;

                if (value < nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Left;
                }
                else if (value > nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Right;
                }
            }

            Node replacementNode = null;

            if (nodeToRemove.Right != null)
            {
                // We have a right node.
                replacementNode = nodeToRemove.Right;

                if (replacementNode.Left == null)
                {
                    // We don't have a left node.
                    replacementNode.Left = nodeToRemove.Left;
                }
                else
                {
                    // We have a left node, lets find the leftmost.
                    var replacementParentNode = nodeToRemove;

                    while (replacementNode.Left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.Left;
                    }

                    replacementParentNode.Left = null;
                    replacementNode.Left = nodeToRemove.Left;
                    replacementNode.Right = nodeToRemove.Right;
                }
            }
            else if (nodeToRemove.Left != null)
            {
                // We only have a left node.
                replacementNode = nodeToRemove.Left;
            }

            if (parentNode == null)
            {
                this.Root = replacementNode;
            }
            else if (parentNode.Left == nodeToRemove)
            {
                // We are a left child.
                parentNode.Left = replacementNode;
            }
            else
            {
                // We are a right child.
                parentNode.Right = replacementNode;
            }
        }

        readonly int COUNT = 5;

        public void PrintTree(Node node)
        {
            this.Print2DUtil(this.Root, 0);
        }

        private void Print2DUtil(Node root, int space)
        {
            // Base case  
            if (root == null)
            {
                return;
            }

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            this.Print2DUtil(root.Right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");

            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }

            Console.Write(this.Root.Value + "\n");

            // Process left child  
            this.Print2DUtil(this.Root.Left, space);
        }
    }
}
