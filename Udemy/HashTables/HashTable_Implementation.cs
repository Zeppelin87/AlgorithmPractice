namespace AlgorithmPractice.Udemy.HashTables
{
    public static class HashTable_Implementation
    {
        public static void Run()
        {
            var hashTable = new HaashTable(2);
            hashTable.Set("Grapes", 1000);
            hashTable.Set("Apples", 54);

            var keys = hashTable.Keys();

            int result = hashTable.Get("Grapes");
        }
    }

    public class MyNode
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public MyNode(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class HaashTable
    {
        public class MyNodes : List<MyNode> { }
        public int Length { get; set; }
        public MyNodes[] Data { get; set; }

        public HaashTable(int size)
        {
            this.Length = size;
            this.Data = new MyNodes[size];
        }

        // Most of the time (no collisions) - O(1)
        public int Get(string key)
        {
            int index = Hash(key);

            if (this.Data[index] == null)
            {
                return 0;
            }

            foreach (var node in this.Data[index])
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }
            }

            return 0;
        }

        // No loops - O(1)
        public void Set(string key, int value)
        {
            int index = Hash(key);

            if (this.Data[index] == null)
            {
                this.Data[index] = new MyNodes();
            }

            this.Data[index].Add(new MyNode(key, value));
        }

        // O(n + m)
        public IList<string> Keys()
        {
            IList<string> result = new List<string>();

            for (int i = 0; i < this.Data.Length; i++)
            {
                if (this.Data[i] != null)
                {
                    for (int j = 0; j < this.Length; j++)
                    {
                        result.Add(this.Data[i][j].Key);
                    }
                }
            }

            return result;
        }

        // Considered to be very fast - O(1)
        private int Hash(string key)
        {
            int hash = 0;

            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.Length;
            }

            return hash;
        }
    }
}
