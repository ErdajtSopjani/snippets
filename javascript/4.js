class ListNode {
   constructor(val, next = null) {
       this.val = val;
       this.next = next;
   }
}

function isPalindrome(head) {
   let vals = [];
   let current = head;
   while (current !== null) {
       vals.push(current.val);
       current = current.next;
   }
   return vals.join('') === vals.slice().reverse().join('');
}

let head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
console.log(isPalindrome(head));
 