using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //Given a linked list, swap every two adjacent nodes and return its head.
    //You may not modify the values in the list's nodes, only nodes itself may be changed.
    //Example:
    //Given 1->2->3->4, you should return the list as 2->1->4->3.
    public class SwapNodesinPairs
    {
        private ListNode TempListNode { get; set; }
        private ListNode NextNode { get; set; }
        private ListNode BeforNode { get; set; }
        public ListNode SwapPairs(ListNode head)
        {
            return Help(1, head);
        }

        //private ListNode Help(int index, ListNode listNode)
        //{
        //    var templistNode = listNode;
        //    var thisNode = GetNode(templistNode);
        //    if (index == 1)
        //    {
        //        TempListNode = thisNode;
        //    }
        //    else if (index != 0 && index % 2 == 0)
        //    {
        //        var tempFirstNode = GetNode(TempListNode);
        //        thisNode.next = tempFirstNode;
        //        TempListNode.next = thisNode;
        //    }
        //    else
        //    {
        //        TempListNode.next = thisNode;
        //    }
        //    Help(index + 1, listNode.next);
        //    if (listNode.next == null) return TempListNode;

        //    return null;
        //}

        private ListNode Help(int index, ListNode listNode)
        {
            Swap(listNode);
            //Help(index + 1, listNode.next.next);
            //if (listNode.next == null) return TempListNode;
            return null;
        }

        private void Swap(ListNode node)
        {

            //var nextNode = node.next;
            //var thirdNode = nextNode.next;
            //node.next = thirdNode;
            //nextNode.next = node;
            //node = nextNode;

            //var firstNode = node;// node = 1 2 3 4
            //node = node.next;//node = 2 3 4
            //node.next = 

            //var tempNode = node;
            //tempNode.next = node.next.next;
            //node.next = tempNode;

            //var tmpeNode = new ListNode(0);
            //tmpeNode = node.next;


            //node.next = node.next.next.next;
            //node.next.next = node;
            //nextTempNode.next = node.next;
            //node = nextTempNode;
        }

        //private ListNode GetNode(ListNode node)
        //{
        //    if (node == null) return null;
        //    node.next = null;
        //    var firstNode = node;
        //    firstNode.next = null;
        //    return firstNode;
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
