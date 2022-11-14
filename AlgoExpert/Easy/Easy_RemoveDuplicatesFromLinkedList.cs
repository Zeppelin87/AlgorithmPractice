namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_RemoveDuplicatesFromLinkedList
    {
        public static void Run()
        {
            //var linkedList = new LinkedList(1);
            //linkedList.AddMany(linkedList, new List<int>() { 1, 3, 4, 4, 4, 5, 6, 6 });

            // Time Complexity: O(n) -- Linear, where 'n' is the number of nodes in the LinkedList.
            // Space Complexity: O(1) -- Constant.
            //var result = Solution(linkedList);
        }

        //private static LinkedList Solution(LinkedList linkedList)
        //{
        //    var current = linkedList;

        //    while (current.next != null)
        //    {
        //        if (current.value == current.next.value)
        //        {
        //            var nodeToDelete = current.next;
        //            current.next = nodeToDelete.next;
        //        }
        //        else
        //        {
        //            current = current.next;
        //        }
        //    }

        //    return linkedList;
        //}

        //private static void PrintLinkedList(LinkedList ll)
        //{
        //    List<int> arr = new List<int>();
        //    var current = ll;

        //    arr.Add(current.value);

        //    while (current.next != null)
        //    {
        //        current = current.next;
        //        arr.Add(current.value);
        //    }

        //    Console.WriteLine("[{0}]", string.Join(", ", arr));
        //}
    }

    //public class LinkedList
    //{
    //    public int value;
    //    public LinkedList next;

    //    public LinkedList(int value)
    //    {
    //        this.value = value;
    //        this.next = null;
    //    }

    //    public LinkedList AddMany(LinkedList ll, List<int> values)
    //    {
    //        var current = ll;

    //        while (current.next != null)
    //        {
    //            current = current.next;
    //        }

    //        foreach (var value in values)
    //        {
    //            current.next = new LinkedList(value);
    //            current = current.next;
    //        }

    //        return ll;
    //    }

    //    public List<int> GetNodesInLinkedList(LinkedList ll)
    //    {
    //        var result = new List<int>();
    //        var current = ll;

    //        result.Add(current.value);

    //        while (current.next != null)
    //        {
    //            current = current.next;
    //            result.Add(current.value);
    //        }

    //        return result;
    //    }
    //}
}
