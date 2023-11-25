public class ListNode {
   int val;
   ListNode next;
   ListNode(int x) { val = x; }
}

public class Solution {
   public static boolean isPalindrome(ListNode head) {
       List<Integer> vals = new ArrayList<>();
       ListNode current = head;
       while (current != null) {
           vals.add(current.val);
           current = current.next;
       }
       return vals.equals(new ArrayList<>(vals.subList(0, vals.size()).stream().collect(Collectors.toList())));
   }

   public static void main(String[] args) {
       ListNode head = new ListNode(1);
       head.next = new ListNode(2);
       head.next.next = new ListNode(2);
       head.next.next.next = new ListNode(1);

       System.out.println(isPalindrome(head));
   }
}
