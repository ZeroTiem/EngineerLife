using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Utilities
{
    public static class Utility
    {
        public static ListNode GenerateListNode(Queue<int> queue, ListNode listNode = null)
        {
            if (queue.Any() == false) return null;
            if (listNode == default)
            {
                listNode = new ListNode(queue.Peek());
                queue.Dequeue();
            }
            if (queue.Any() == false) return listNode;
            listNode.next = new ListNode(queue.Peek());
            queue.Dequeue();
            GenerateListNode(queue, listNode.next);
            return listNode;
        }
    }
}
