namespace AlgorithmPractice.Udemy.Algorithms.Searching
{
    public class BfsDfsNodeAndBST
    {
    }

    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(int value)
        {
            this.Left = null;
            this.Right = null;
            this.Value = value;
        }
    }

    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            this.Root = null;
        }

        public void Insert(int value)
        {
            var newNode = new Node(value);

            if (this.Root == null)
            {
                Root = newNode;
                return;
            }

            var currentNode = this.Root;

            while (true)
            {
                if (currentNode.Value > value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        return;
                    }

                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        return;
                    }

                    currentNode = currentNode.Right;
                }
            }
        }
    }
}
