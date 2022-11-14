namespace AlgorithmPractice.Udemy.Algorithms.Searching
{
    public static class DepthFirstSearchExample
    {
        public static void Run()
        {
            //          9
            //      4       20
            //    1   6   15  170
            var tree = new DFSBinarySearchTree();
            //tree.Insert(9);
            //tree.Insert(4); 
            //tree.Insert(6);
            //tree.Insert(20);
            //tree.Insert(170);
            //tree.Insert(15);
            //tree.Insert(1);

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);

            var InOrder = tree.DFSInOrder();
            PrintList(InOrder);
            var PreOrder = tree.DFSPreOrder();
            PrintList(PreOrder);
            var PostOrder = tree.DFSPostOrder();
            PrintList(PostOrder);
        }

        private static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();
        }
    }

    public class DFSBinarySearchTree
    {
        public Node Root;

        public DFSBinarySearchTree()
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

        public List<int> DFSInOrder()
        {
            var result = new List<int>();
            TraverseInOrder(this.Root, result);
            return result;
        }

        public List<int> DFSPreOrder()
        {
            var result = new List<int>();
            TraversePreOrder(this.Root, result);
            return result;
        }

        public List<int> DFSPostOrder()
        {
            var result = new List<int>();
            TraversePostOrder(this.Root, result);
            return result;
        }

        //          9
        //      4       20
        //    1   6   15  170
        // -----------------------------------
        // InOrder = [1, 4, 6, 9, 15, 20, 170]
        public List<int> TraverseInOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraverseInOrder(node.Left, list);
            }

            list.Add(node.Value);

            if (node.Right != null)
            {
                TraverseInOrder(node.Right, list);
            }

            return list;
        }

        //          9
        //      4       20
        //    1   6   15  170
        // -----------------------------------
        // PreOrder = [9, 4, 1, 6, 20, 15, 170]
        public List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);

            if (node.Left != null)
            {
                TraversePreOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                TraversePreOrder(node.Right, list);
            }

            return list;
        }

        //          9
        //      4       20
        //    1   6   15  170
        // -----------------------------------
        // PostOrder = [1, 6, 4, 15, 170, 20, 9]
        public List<int> TraversePostOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraversePostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                TraversePostOrder(node.Right, list);
            }

            list.Add(node.Value);

            return list;
        }
    }
}
