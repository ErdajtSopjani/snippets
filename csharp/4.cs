using System;

public class Solution {

  public static bool IsPalindrome(ListNode head) {
    StringBuilder sb = new StringBuilder();
    ListNode current = head;

    while (current != null) {
      sb.Append(current.val);
      current = current.next;
    }
       
    string items = sb.ToString();
    string reversed = new string(items.ToCharArray().Reverse().ToArray());
    return reversed == items;
  }
}
