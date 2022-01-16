namespace ReverseSinglyLinkedList
{
    public class Solution {
        public ListNode ReverseList(ListNode head) {

            if (head == null || head.next == null)
            {
                return head;
            }

            var List = new List<ListNode>();
            ListNode? curr = head;
            while (curr != null)
            {
                List.Add(curr);
                curr = curr.next;
            }

            List.Reverse();
            for (int i = 0; i < List.Count - 1; i++)
            {
                List[i].next = List[i + 1];
            }

            List[^1].next = null;

            return List.First();
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