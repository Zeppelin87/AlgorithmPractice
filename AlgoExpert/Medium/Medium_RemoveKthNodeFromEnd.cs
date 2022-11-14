namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_RemoveKthNodeFromEnd
    {
        public static void Run()
        {
            //int k = 4;
            //var ll = new LinkedList(0);
            //ll.addMany(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            //// Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the LinkedList).
            //// Space Complexity: O(n) -- Linear.
            //Solution(ll, k);

            //// Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the LinkedList).
            //// Space Complexity: O(1) -- Constant.
            //Solution_ConstantSpace(ll, k);
        }

        //private static void Solution_ConstantSpace(LinkedList head, int k)
        //{
        //    int counter = 1;
        //    var first = head;
        //    var second = head;

        //    while (counter <= k)
        //    {
        //        second = second.Next;
        //        counter++;
        //    }

        //    if (second == null)
        //    {
        //        head.Value = head.Next.Value;
        //        head.Next = head.Next.Next;
        //        return;
        //    }

        //    while (second.Next != null)
        //    {
        //        second = second.Next;
        //        first = first.Next;
        //    }

        //    first.Next = first.Next.Next;
        //}

        //private static void Solution(LinkedList head, int k)
        //{
        // Input head of the 'll' should remain the head of the 'll' after removal, even if the head is the node that's supposed to be removed.
        //  - if remove Head, simply mutate 'head.Value' and 'head.Next' pointer.

        // Remove the 'Kth' node from the END of the LinkedList.

        //var array = new List<int>();
        //var currentNode = head;

        //while (currentNode != null)
        //{
        //    array.Add(currentNode.Value);
        //    currentNode = currentNode.Next;
        //}

        //// Removing Head.
        //if (k == array.Count)
        //{
        //    var node = head;
        //    LinkedList previous = null;

        //    while (node.Next != null)
        //    {
        //        previous = node;
        //        node.Value = node.Next.Value;

        //        node = node.Next;

        //        if (node.Next == null)
        //        {
        //            previous.Next = null;
        //            return;
        //        }
        //    }

        //}

        //int previousNodeValue = array[array.Count - k - 1];
        //int valueToRemove = array[array.Count - k];

        //currentNode = head;
        //LinkedList previousNode = null;
        //while (currentNode != null && currentNode.Value != valueToRemove)
        //{
        //    previousNode = currentNode;
        //    currentNode = currentNode.Next;
        //}

        //previousNode.Next = currentNode.Next;
        //}
    }

    //public class LinkedList
    //{
    //    public int Value;
    //    public LinkedList Next = null;

    //    public LinkedList(int value)
    //    {
    //        Value = value;
    //    }

    //    public void addMany(int[] values)
    //    {
    //        LinkedList current = this;

    //        while (current.Next != null)
    //        {
    //            current = current.Next;
    //        }

    //        foreach (int value in values)
    //        {
    //            current.Next = new LinkedList(value);
    //            current = current.Next;
    //        }
    //    }

    //    public List<int> getNodesInArray()
    //    {
    //        List<int> nodes = new List<int>();
    //        LinkedList current = this;

    //        while (current != null)
    //        {
    //            nodes.Add(current.Value);
    //            current = current.Next;
    //        }

    //        return nodes;
    //    }
    //}
}
