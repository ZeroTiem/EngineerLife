using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Eazy
{
    public class No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
    {
        public int GetDecimalValue(ListNode head)
        {
            return BinaryCumulative(head, 0);
        }

        public int BinaryCumulative(ListNode head, int sum)
        {
            return head == null ? sum : BinaryCumulative(head.next, sum * 2 + (head.val));
        }
    }
}
