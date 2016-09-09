/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode reverseBetween(ListNode head, int m, int n) {
        if (head == null || head.next == null || m == n) return head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        ListNode prev = dummy;
        for (int i=0; i<m-1; i++) {
            prev = prev.next;
        }
        
        ListNode cur = prev.next;
        for (int i=0; i<n-m; i++) {
            ListNode temp = cur.next;
            cur.next = cur.next.next;
            temp.next = prev.next;
            prev.next = temp;
        }
        
        return dummy.next;
    }
}