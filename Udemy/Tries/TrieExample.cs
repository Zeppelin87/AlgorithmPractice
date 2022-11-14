namespace AlgorithmPractice.Udemy.Tries
{
    public static class TrieExample
    {
        public static void Run()
        {
            string[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
        }
    }

    public class Trie
    {
        private static readonly int ALPHABET_SIZE = 26;

        public TrieNode Root;

        public void Insert(string key)
        {
            int level;
            int length = key.Length;
            int index;

            TrieNode pCrawl = Root;

            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.Children[index] == null)
                {
                    pCrawl.Children[index] = new TrieNode();
                }

                pCrawl = pCrawl.Children[index];
            }

            pCrawl.IsEndOfWord = true;
        }

        public bool Search(string key)
        {
            int level;
            int length = key.Length;
            int index;

            TrieNode pCrawl = Root;

            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';

                if (pCrawl.Children[index] == null)
                {
                    return false;
                }

                pCrawl = pCrawl.Children[index];
            }

            return pCrawl.IsEndOfWord;
        }
    }

    public class TrieNode
    {
        private static readonly int ALPHABET_SIZE = 26;

        public TrieNode[] Children = new TrieNode[ALPHABET_SIZE];

        public bool IsEndOfWord;

        public TrieNode()
        {
            IsEndOfWord = false;
            for (int i = 0; i < ALPHABET_SIZE; i++)
            {
                Children[i] = null;
            }
        }
    }
}
