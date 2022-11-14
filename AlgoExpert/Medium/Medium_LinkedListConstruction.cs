using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_LinkedListConstruction
    {
        public static void Run()
        {
            //var linkedList = new DoublyLinkedList();
            //var one = new Node(1);
            //var two = new Node(2);
            //var three = new Node(3);
            //var three2 = new Node(3);
            //var three3 = new Node(3);
            //var four = new Node(4);
            //var five = new Node(5);
            //var six = new Node(6);
            //bindNodes(one, two);
            //bindNodes(two, three);
            //bindNodes(three, four);
            //bindNodes(four, five);
            //linkedList.Head = one;
            //linkedList.Tail = five;

            //linkedList.SetHead(four);
            //linkedList.SetTail(six);
            //linkedList.InsertBefore(six, three);
            //linkedList.InsertAfter(six, three2);
            //linkedList.InsertAtPosition(1, three3);
            //linkedList.RemoveNodesWithValue(3);
            //linkedList.Remove(two);
        }

        //private static void bindNodes(Node nodeOne, Node nodeTwo)
        //{
        //	nodeOne.Next = nodeTwo;
        //	nodeTwo.Prev = nodeOne;
        //}
    }

    // Do not edit the class below.
    //public class Node
    //{
    //	public int Value;
    //	public Node Prev;
    //	public Node Next;

    //	public Node(int value)
    //	{
    //		this.Value = value;
    //	}
    //}

    //public class DoublyLinkedList
    //{
    //	public Node Head;
    //	public Node Tail;

    //	// O(1) time | O(1) space.
    //	public void SetHead(Node node)
    //	{
    //		if (this.Head == null)
    //           {
    //			this.Head = node;
    //			this.Tail = node;
    //			return;
    //           }

    //		InsertBefore(this.Head, node);
    //	}

    //	// O(1) time | O(1) space.
    //	public void SetTail(Node node)
    //	{
    //		if (this.Tail == null)
    //           {
    //			SetHead(node);
    //			return;
    //           }

    //		InsertAfter(this.Tail, node);
    //	}

    //	// O(1) time | O(1) space.
    //	public void InsertBefore(Node node, Node nodeToInsert)
    //	{
    //		if (nodeToInsert == this.Head && nodeToInsert == this.Tail)
    //           {
    //			return;
    //           }

    //		Remove(nodeToInsert);

    //		nodeToInsert.Prev = node.Prev;
    //		nodeToInsert.Next = node;

    //		if (node.Prev == null)
    //           {
    //			this.Head = nodeToInsert;
    //           }
    //		else
    //           {
    //			node.Prev.Next = nodeToInsert;
    //           }

    //		node.Prev = nodeToInsert;
    //	}

    //	// O(1) time | O(1) space.
    //	public void InsertAfter(Node node, Node nodeToInsert)
    //	{
    //		if (nodeToInsert == this.Head && nodeToInsert == this.Tail)
    //           {
    //			return;
    //           }

    //		Remove(nodeToInsert);
    //		nodeToInsert.Prev = node;
    //		nodeToInsert.Next = node.Next;

    //		if (node.Next == null)
    //		{
    //			this.Tail = nodeToInsert;
    //		}
    //		else
    //           {
    //			node.Next.Prev = nodeToInsert;
    //           }

    //		node.Next = nodeToInsert;
    //	}

    //	// O(p) time | O(1) space.
    //	public void InsertAtPosition(int position, Node nodeToInsert)
    //	{
    //		if (position == 1)
    //           {
    //			SetHead(nodeToInsert);
    //			return;
    //           }

    //		var node = this.Head;
    //		int currentPosition = 1;

    //		while (node != null && currentPosition++ != position)
    //		{
    //			node = node.Next;
    //		}

    //		if (node != null)
    //		{
    //			InsertBefore(node, nodeToInsert);
    //		}
    //		else
    //		{
    //			SetTail(nodeToInsert);
    //		}
    //	}

    //	// O(n) time | O(1) space.
    //	public void RemoveNodesWithValue(int value)
    //	{
    //		var node = this.Head;

    //		while (node != null)
    //           {
    //			var nodeToRemove = node;
    //			node = node.Next;

    //			if (nodeToRemove.Value == value)
    //               {
    //				Remove(nodeToRemove);
    //               }
    //           }
    //	}

    //	// O(1) time | O(1) space.
    //	public void Remove(Node node)
    //	{
    //		if (node == this.Head)
    //           {
    //			this.Head = this.Head.Next;
    //           }

    //		if (node == this.Tail)
    //           {
    //			this.Tail = this.Tail.Prev;
    //           }

    //		RemoveNodeBindings(node);
    //	}

    //	// O(n) time | O(1) space.
    //	public bool ContainsNodeWithValue(int value)
    //	{
    //		var currentNode = this.Head;

    //		while (currentNode != null && currentNode.Value != value)
    //           {
    //			currentNode = currentNode.Next;
    //           }

    //		return false;
    //	}

    //	private void RemoveNodeBindings(Node node)
    //       {
    //		// [46, 24, 37, 5, 9];

    //		if (node.Prev != null)
    //           {
    //			node.Prev.Next = node.Next;
    //           }

    //		if (node.Next != null)
    //           {
    //			node.Next.Prev = node.Prev;
    //           }

    //		node.Prev = null;
    //		node.Next = null;
    //	}
    //}
}
