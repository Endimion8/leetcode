namespace ReverseSinglyLinkedList
{
    // https://leetcode.com/problems/reverse-linked-list/
    public class Solution {
        public ListNode ReverseList(ListNode? head)
        {

            var curr = head;
            ListNode? prev = null;

            return ReverseList(curr, prev);
        }

        public ListNode? ReverseList(ListNode? curr, ListNode? prev)
        {
            if (curr == null)
            {
                return prev;
            }

            var nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
            
            return ReverseList(curr, prev);
        }
    }

    public class ListNode {
        public int val { get; set; }
        public ListNode? next { get; set; }
        
        public ListNode(int val, ListNode? next) {
            this.val = val;
            this.next = next;
        }
    }
}