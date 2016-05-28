/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        if(node==null) return;
        ListNode curNode = new ListNode(0);
        curNode.next = node;
        while(curNode.next.next != null){
            curNode.next.val = curNode.next.next.val;
            curNode = curNode.next;
        }
        curNode.next = null;
    }
}