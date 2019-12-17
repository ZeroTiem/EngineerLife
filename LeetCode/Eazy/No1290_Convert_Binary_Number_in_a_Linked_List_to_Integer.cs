using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Eazy
{
    public class No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
    {
        private int Sum { get; set; }
        private int Magnification { get; set; } = 0;

        public int GetDecimalValue(ListNode head)
        {
            if (Magnification == 0)
                Magnification = 1;
            else
                Magnification *= 2;

            Sum += head.val == 1 ? Magnification : 0;

            if (head.next != null)
                GetDecimalValue(head.next);

            return Sum;
        }
    }
}
