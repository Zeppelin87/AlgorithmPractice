namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_FindNodesDistanceK
    {
        public static void Run()
        {
            int k = 2;
            int target = 3;

            var root = new BinaryTree(1);
            root.left = new BinaryTree(2);
            root.right = new BinaryTree(3);
            root.left.left = new BinaryTree(4);
            root.left.right = new BinaryTree(5);
            root.right.right = new BinaryTree(6);
            root.right.right.left = new BinaryTree(7);
            root.right.right.right = new BinaryTree(8);

            // 
            // Where: 
            var result = Solution(root, target, k);
        }

        private static List<int> Solution(BinaryTree root, int target, int k)
        {
            var result = new List<int>();

            var leftSubtreeDepths = new Dictionary<int, int>();
            var rightSubtreeDepths = new Dictionary<int, int>();

            CalculateNodeDepth(root.left, 0, leftSubtreeDepths);
            CalculateNodeDepth(root.right, 0, rightSubtreeDepths);

            int targetDepth = 0;

            if (root.value != target)
            {
                if (leftSubtreeDepths.ContainsKey(target))
                {
                    targetDepth = leftSubtreeDepths[target];

                    AddTargetSubtreeDepths(leftSubtreeDepths, targetDepth, k, target, result);
                    AddOtherSubtreeDepths(rightSubtreeDepths, targetDepth, k, result);
                }
                else
                {
                    targetDepth = rightSubtreeDepths[target];
                    AddTargetSubtreeDepths(rightSubtreeDepths, targetDepth, k, target, result);
                    AddOtherSubtreeDepths(leftSubtreeDepths, targetDepth, k, result);
                }
            }
            else
            {
                AddDepthsWhenRootIsTarget(leftSubtreeDepths, k, result);
                AddDepthsWhenRootIsTarget(rightSubtreeDepths, k, result);
            }

            if (targetDepth == 1 && k == 1)
            {
                result.Add(root.value);
            }

            return result;
        }

        private static void AddTargetSubtreeDepths(Dictionary<int, int> dict, int targetDepth, int k, int target, List<int> result)
        {
            int depth1 = targetDepth + k;
            int depth2 = targetDepth - k;

            foreach (var node in dict)
            {
                if (k == 2 && node.Value == targetDepth && node.Key != target)
                {
                    result.Add(node.Key);
                }

                if (node.Value == depth1 || node.Value == depth2)
                {
                    result.Add(node.Key);
                }
            }
        }

        private static void AddOtherSubtreeDepths(Dictionary<int, int> dict, int targetDepth, int k, List<int> result)
        {
            foreach (var node in dict)
            {
                if (targetDepth + node.Value == k)
                {
                    result.Add(node.Key);
                }
            }
        }

        private static void AddDepthsWhenRootIsTarget(Dictionary<int, int> dict, int k, List<int> result)
        {
            foreach (var node in dict)
            {
                if (node.Value == k)
                {
                    result.Add(node.Key);
                }
            }
        }

        private static void CalculateNodeDepth(BinaryTree tree, int depth, Dictionary<int, int> depths)
        {
            if (tree == null)
            {
                return;
            }

            depth += 1;
            depths.Add(tree.value, depth);

            CalculateNodeDepth(tree.left, depth, depths);
            CalculateNodeDepth(tree.right, depth, depths);
        }
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }
}
