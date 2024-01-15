using System;

public class Solution {
  static void Main(string[] args) {
    ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
    Console.WriteLine(IsPalindrome(head));

    Console.Read();
  }

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
