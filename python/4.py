class ListNode:
   def __init__(self, x):
       self.val = x
       self.next = None

def is_palindrome(head):
   vals = []
   current = head
   while current is not None:
       vals.append(current.val)
       current = current.next
   return vals == vals[::-1]

head = ListNode(1)
head.next = ListNode(2)
head.next.next = ListNode(2)
head.next.next.next = ListNode(1)

print(is_palindrome(head))
