namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_YoungestCommonAncestor
    {
        public static void Run()
        {
            var trees = SetupTestData_GetNewTrees();
            trees['A'].AddAsAncestor(new AncestralTree[] { trees['B'], trees['C'] });
            trees['B'].AddAsAncestor(new AncestralTree[] { trees['D'], trees['E'] });
            trees['D'].AddAsAncestor(new AncestralTree[] { trees['H'], trees['I'] });
            trees['C'].AddAsAncestor(new AncestralTree[] { trees['F'], trees['G'] });

            // Time Complexity: O(d) -- Linear (where 'd' is the depth (height) of the Tree).
            // Space Complexity: O(d) -- Linear.
            //var result = Solution(trees['A'], trees['E'], trees['I']);

            // Time Complexity: O(d) -- Linear (where 'd' is the depth (height) of the Tree).
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_Recursion(trees['A'], trees['E'], trees['I']);
        }

        private static AncestralTree Solution_Recursion(AncestralTree topAncestor, AncestralTree descendantOne, AncestralTree descendantTwo)
        {
            int depthOne = GetDescendantDepth(descendantOne, topAncestor);
            int depthTwo = GetDescendantDepth(descendantTwo, topAncestor);

            if (depthOne > depthTwo)
            {
                return BacktrackAncestralTree(descendantOne, descendantTwo, depthOne - depthTwo);
            }
            else
            {
                return BacktrackAncestralTree(descendantTwo, descendantOne, depthTwo - depthOne);
            }
        }

        private static int GetDescendantDepth(AncestralTree descendant, AncestralTree topAncestor)
        {
            int depth = 0;

            while (descendant != topAncestor)
            {
                depth++;
                descendant = descendant.ancestor;
            }

            return depth;
        }

        private static AncestralTree BacktrackAncestralTree(AncestralTree lowerDescendant, AncestralTree higherDescendant, int diff)
        {
            while (diff > 0)
            {
                lowerDescendant = lowerDescendant.ancestor;
                diff--;
            }

            while (lowerDescendant != higherDescendant)
            {
                lowerDescendant = lowerDescendant.ancestor;
                higherDescendant = higherDescendant.ancestor;
            }

            return lowerDescendant;
        }

        private static AncestralTree Solution(AncestralTree topAncestor, AncestralTree descendantOne, AncestralTree descendantTwo)
        {
            var youngestAncestor = topAncestor;
            var names = new List<char>();

            var currentNode = descendantOne;
            names.Add(currentNode.name);

            while (currentNode.ancestor != null)
            {
                currentNode = currentNode.ancestor;
                names.Add(currentNode.name);
            }

            currentNode = descendantTwo;

            while (currentNode.ancestor != null)
            {
                if (names.Contains(currentNode.name))
                {
                    youngestAncestor = currentNode;
                    break;
                }

                currentNode = currentNode.ancestor;
            }

            return youngestAncestor;
        }

        private static Dictionary<char, AncestralTree> SetupTestData_GetNewTrees()
        {
            var trees = new Dictionary<char, AncestralTree>();
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char a in alphabet)
            {
                trees.Add(a, new AncestralTree(a));
            }

            trees['A'].AddAsAncestor(new AncestralTree[] {
                trees['B'],
                trees['C'],
                trees['D'],
                trees['E'],
                trees['F']
            });

            return trees;
        }
    }

    public class AncestralTree
    {
        public char name;
        public AncestralTree ancestor;

        public AncestralTree(char name)
        {
            this.name = name;
        }

        // This mehtod is for testing only.
        public void AddAsAncestor(AncestralTree[] descendants)
        {
            foreach (var descendant in descendants)
            {
                descendant.ancestor = this;
            }
        }
    }
}
