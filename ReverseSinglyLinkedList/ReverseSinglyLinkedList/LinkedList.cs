namespace ReverseSinglyLinkedList
{
    public class Solution {
        public ListNode ReverseList(ListNode? head) {

            if (head?.next == null)
            {
                return head;
            }
            
            
            ListNode? curr = null;
            ListNode? prev = null;
            while (head != null)
            {
                prev = curr;
                curr = head;
                head = head.next;
                curr.next = prev;
            }

            return curr;
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