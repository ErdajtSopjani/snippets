#include <iostream>
#include <vector>
#include <algorithm>

struct ListNode {
   int val;
   ListNode *next;
   ListNode(int x) : val(x), next(NULL) {}
};

bool isPalindrome(ListNode* head) {
   std::vector<int> vals;
   ListNode* current = head;
   while (current != NULL) {
       vals.push_back(current->val);
       current = current->next;
   }
   return vals == std::vector<int>(vals.rbegin(), vals.rend());
}

int main() {
   ListNode* head = new ListNode(1);
   head->next = new ListNode(2);
   head->next->next = new ListNode(2);
   head->next->next->next = new ListNode(1);

   std::cout << isPalindrome(head) << std::endl;
   return 0;
}
