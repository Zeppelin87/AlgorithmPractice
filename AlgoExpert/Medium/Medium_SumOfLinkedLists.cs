namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SumOfLinkedLists
    {
        public static void Run()
        {
            //var ll1 = addMany(new LinkedList(2), new int[] { 4, 7, 1 });

            //var ll2 = addMany(new LinkedList(9), new int[] { 4, 5 });

            //// Time Complexity: O(max(n, m)) -- (where 'n' is the number of nodes in llOne and 'm' is the number of nodes in llTwo).
            //// Space Complexity: O(max(n, m)).
            ////var result = Solution(ll1, ll2);

            //// Time Complexity: O(max(n, m)) -- (where 'n' is the number of nodes in llOne and 'm' is the number of nodes in llTwo).
            //// Space Complexity: O(max(n, m)).
            //var result2 = Solution_Clean(ll1, ll2);
        }

        //private static LinkedList Solution_Clean(LinkedList linkedListOne, LinkedList linkedListTwo)
        //{
        //    var newLinkedListHeadPointer = new LinkedList(0);
        //    var currentNode = newLinkedListHeadPointer;
        //    int carry = 0;

        //    var nodeOne = linkedListOne;
        //    var nodeTwo = linkedListTwo;

        //    while (nodeOne != null || nodeTwo != null || carry != 0)
        //    {
        //        int valueOne = nodeOne != null ? nodeOne.value : 0;
        //        int valueTwo = nodeTwo != null ? nodeTwo.value : 0;
        //        int sumOfValues = valueOne + valueTwo + carry;

        //        int newValue = sumOfValues % 10;
        //        var newNode = new LinkedList(newValue);
        //        currentNode.next = newNode;
        //        currentNode = newNode;

        //        carry = sumOfValues / 10;
        //        nodeOne = nodeOne != null ? nodeOne.next : null;
        //        nodeTwo = nodeTwo != null ? nodeTwo.next : null;
        //    }

        //    return newLinkedListHeadPointer.next;
        //}

        //private static LinkedList Solution(LinkedList linkedListOne, LinkedList linkedListTwo)
        //{
        //    var array1 = new List<int>();
        //    var array2 = new List<int>();

        //    var currentNode = linkedListOne;
        //    while (currentNode != null)
        //    {
        //        array1.Add(currentNode.value);
        //        currentNode = currentNode.next;
        //    }

        //    currentNode = linkedListTwo;
        //    while (currentNode != null)
        //    {
        //        array2.Add(currentNode.value);
        //        currentNode = currentNode.next;
        //    }

        //    array1.Reverse();
        //    array2.Reverse();

        //    int num1 = 0;
        //    for (int i = 0; i < array1.Count; i++)
        //    {
        //        num1 += array1[i] *Convert.ToInt32(Math.Pow(10, array1.Count - i - 1));
        //    }

        //    int num2 = 0;
        //    for (int i = 0; i < array2.Count; i++)
        //    {
        //        num2 += array2[i] * Convert.ToInt32(Math.Pow(10, array2.Count - i - 1));
        //    }

        //    int num3 = num1 + num2;
        //    var array3 = new List<int>();
        //    foreach (var item in num3.ToString())
        //    {
        //        array3.Add(Convert.ToInt32(item.ToString()));
        //    }

        //    array3.Reverse();
        //    int[] resultArr = new int[array3.Count - 1];
        //    for (int i = 1; i < array3.Count; i++)
        //    {
        //        resultArr[i - 1] = array3[i];
        //    }

        //    var linkedList = addMany(new LinkedList(array3[0]), resultArr);

        //    return linkedList;
        //}

        //private static LinkedList addMany(LinkedList linkedList, int[] values)
        //{
        //    var current = linkedList;

        //    while (current.next != null)
        //    {
        //        current = current.next;
        //    }

        //    foreach (var value in values)
        //    {
        //        current.next = new LinkedList(value);
        //        current = current.next;
        //    }

        //    return linkedList;
        //}
    }

    //public class LinkedList
    //{
    //    public int value;
    //    public LinkedList next;

    //    public LinkedList(int value)
    //    {
    //        this.value = value;
    //    }
    //}
}
