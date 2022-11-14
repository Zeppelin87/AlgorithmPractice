namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_BoggleBoard
    {
        public static void Run()
        {
            char[,] board = {
                {'t', 'h', 'i', 's', 'i', 's', 'a'},
                {'s', 'i', 'm', 'p', 'l', 'e', 'x'},
                {'b', 'x', 'x', 'x', 'x', 'e', 'b'},
                {'x', 'o', 'g', 'g', 'l', 'x', 'o'},
                {'x', 'x', 'x', 'D', 'T', 'r', 'a'},
                {'R', 'E', 'P', 'E', 'A', 'd', 'x'},
                {'x', 'x', 'x', 'x', 'x', 'x', 'x'},
                {'N', 'O', 'T', 'R', 'E', '-', 'P'},
                {'x', 'x', 'D', 'E', 'T', 'A', 'E'},
            };

            string[] words = { "this", "is", "not", "a", "simple", "boggle", "board", "test", "REPEATED", "NOTRE-PEATED" };

            // Time Complexity: O(nm * 8^s + ws).
            // Space Complexity: O(ws + nm).
            // Where: 's' is the length of the longest word, 'w' is the number of words, 'n' is the length of the matrix 'board[][]', 'm' is the width of the matrix 'board[][]'.
            //  - '* 8^s' accounts for the time complexity of searching all 8 neighbors (up/dow/left/right/diagonals) foreach node in the matrix 'board[][]' you are checking.
            var result = Solution(board, words);
        }

        private static List<string> Solution(char[,] board, string[] words)
        {
            var trie = new Trie();

            for (int i = 0; i < words.Length; i++)
            {
                trie.Insert(words[i]);
            }

            var finalWords = new HashSet<string>();
            bool[,] visited = new bool[board.GetLength(0), board.GetLength(1)];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Explore(board, row, col, trie.Root, visited, finalWords);
                }
            }

            var finalWordsArray = new List<string>();
            foreach (var key in finalWords)
            {
                finalWordsArray.Add(key);
            }

            return finalWordsArray;
        }

        private static void Explore(char[,] board, int row, int col, TrieNode trieNode, bool[,] visited, HashSet<string> finalWords)
        {
            if (visited[row, col])
            {
                return;
            }

            char letter = board[row, col];

            if (!trieNode.Children.ContainsKey(letter))
            {
                return;
            }

            visited[row, col] = true;

            trieNode = trieNode.Children[letter];

            if (trieNode.Children.ContainsKey('*'))
            {
                finalWords.Add(trieNode.Word);
            }

            var neighbors = GetNeighbors(board, row, col);

            foreach (int[] neighbor in neighbors)
            {
                Explore(board, neighbor[0], neighbor[1], trieNode, visited, finalWords);
            }

            visited[row, col] = false;
        }

        private static List<int[]> GetNeighbors(char[,] board, int row, int col)
        {
            var neighbors = new List<int[]>();

            if (row > 0 && col > 0)
            {
                neighbors.Add(new int[] { row - 1, col - 1 }); // diagonal left (upper).
            }

            if (row < board.GetLength(0) - 1 && col > 0)
            {
                neighbors.Add(new int[] { row + 1, col - 1 }); // diagonal left (lower).
            }

            if (row > 0 && col < board.GetLength(1) - 1)
            {
                neighbors.Add(new int[] { row - 1, col + 1 }); // diagonal right (upper).
            }

            if (row < board.GetLength(0) - 1 && col < board.GetLength(1) - 1)
            {
                neighbors.Add(new int[] { row + 1, col + 1 }); // diagonal right (lower).
            }

            if (row > 0)
            {
                neighbors.Add(new int[] { row - 1, col }); // Up.
            }

            if (row < board.GetLength(0) - 1)
            {
                neighbors.Add(new int[] { row + 1, col }); // Down.
            }

            if (col > 0)
            {
                neighbors.Add(new int[] { row, col - 1 }); // Left.
            }

            if (col < board.GetLength(1) - 1)
            {
                neighbors.Add(new int[] { row, col + 1 }); // Right.
            }

            return neighbors;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public string Word = "";
    }

    public class Trie
    {
        public TrieNode Root = new TrieNode();
        public char EndSymbol = '*';

        public void Insert(string str)
        {
            TrieNode node = this.Root;

            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];

                if (!node.Children.ContainsKey(letter))
                {
                    node.Children.Add(letter, new TrieNode());
                }

                node = node.Children[letter];
            }

            node.Children[this.EndSymbol] = null;
            node.Word = str;
        }
    }
}
