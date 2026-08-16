using UnityEngine;

public class PalindromeLinkedListSolution : MonoBehaviour
{
    //  Definition for singly-linked list.
      public class ListNode {
          public int val;
          public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            // Ortayý bul
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Tek elemanlý orta kýsmý atla
            if (fast != null)
                slow = slow.next;

            // Ýkinci yarýyý ters çevir
            ListNode prev = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            // Karþýlaþtýr
            ListNode left = head;
            ListNode right = prev;

            while (right != null)
            {
                if (left.val != right.val)
                    return false;

                left = left.next;
                right = right.next;
            }

            return true;
        }
    }
}
