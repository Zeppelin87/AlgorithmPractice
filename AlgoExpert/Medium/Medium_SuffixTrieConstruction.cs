namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SuffixTrieConstruction
    {
        public static void Run()
        {
            //var trie = new SuffixTrie("babc");

            // Creation:
            // Time Complexity: O(M).
            // Space Complexity: O(1).
            // Where: 'M' is the length of whatever string we're searching for in the Suffix Tree.

            // Searching:
            // Time Complexity: O(N^2).
            // Space Complexity: O(N^2).
        }
    }

    //public class TrieNode
    //{
    //    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    //}

    //public class SuffixTrie
    //{
    //    public TrieNode root = new TrieNode();
    //    public char endSymbol = '*';

    //    public SuffixTrie(string str)
    //    {
    //        PopulateSuffixTrieFrom(str);
    //    }

    //    public void PopulateSuffixTrieFrom(string str)
    //    {
    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            InsertSubstringStartingAt(i, str);
    //        }
    //    }

    //    public void InsertSubstringStartingAt(int i, string str)
    //    {
    //        TrieNode node = root;

    //        for (int j = i; j < str.Length; j++)
    //        {
    //            char letter = str[j];

    //            if (!node.Children.ContainsKey(letter))
    //            {
    //                node.Children.Add(letter, new TrieNode());
    //            }

    //            node = node.Children[letter];
    //        }

    //        node.Children[endSymbol] = null;
    //    }

    //    public bool Contains(string str)
    //    {
    //        TrieNode node = root;

    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            char letter = str[i];

    //            if (!node.Children.ContainsKey(letter))
    //            {
    //                return false;
    //            }

    //            node = node.Children[letter];
    //        }

    //        return node.Children.ContainsKey(endSymbol);
    //    }
    //}
}
