use std::collections::VecDeque;

#[derive(PartialEq, Eq, Clone, Debug)]
struct ListNode {
   val: i32,
   next: Option<Box<ListNode>>,
}

impl ListNode {
   fn new(val: i32) -> Self {
       ListNode {
           next: None,
           val,
       }
   }
}

fn is_palindrome(head: Option<Box<ListNode>>) -> bool {
   let mut vals = VecDeque::new();
   let mut current = head;
   while let Some(node) = current {
       vals.push_back(node.val);
       current = node.next;
   }
   vals == vals.iter().rev().cloned().collect::<VecDeque<_>>()
}

let mut head = Some(Box::new(ListNode::new(1)));
head.as_mut().unwrap().next = Some(Box::new(ListNode::new(2)));
head.as_mut().unwrap().next.as_mut().unwrap().next = Some(Box::new(ListNode::new(2)));
head.as_mut().unwrap().next.as_mut().unwrap().next.as_mut().unwrap().next = Some(Box::new(ListNode::new(1)));

println!("{}", is_palindrome(head));
