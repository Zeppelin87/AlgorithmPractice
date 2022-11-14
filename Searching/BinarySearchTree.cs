namespace AlgorithmPractice.Searching
{
    public class BinarySearchTree<TKey, TValue> where TKey : IComparer<TKey>
    {
        private Node Root;

        private class Node
        {
            public TKey Key;
            public TValue Value;
            public Node Left, Right;
            public int N;

            public Node(TKey key, TValue value, int N)
            {
                this.Key = key;
                this.Value = value;
                this.N = N;
            }
        }

        public int Size()
        {
            return Size(Root);
        }

        private int Size(Node x)
        {
            if (x == null)
            {
                return 0;
            }
            else
            {
                return x.N;
            }
        }

        public TValue? Get(TKey key)
        {
            return Get(Root, key);
        }

        private TValue? Get(Node x, TKey key)
        {
            if (x == null)
            {
                return default(TValue);
            }

            int compare = key.Compare(key, x.Key);

            if (compare < 0)
            {
                return Get(x.Left, key);
            }
            else if (compare > 0)
            {
                return Get(x.Right, key);
            }
            else
            {
                return x.Value;
            }
        }

        public void Put(TKey key, TValue value)
        {
            Root = Put(Root, key, value);
        }

        private Node Put(Node x, TKey key, TValue value)
        {
            if (x == null)
            {
                return new Node(key, value, 1);
            }

            int compare = key.Compare(key, x.Key);

            if (compare < 0)
            {
                x.Left = Put(x.Left, key, value);
            }
            else if (compare > 0)
            {
                x.Right = Put(x.Right, key, value);
            }
            else
            {
                x.Value = value;
            }

            x.N = Size(x.Left) + Size(x.Right) + 1;
            return x;
        }
    }
}
