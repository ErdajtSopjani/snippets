#include <iostream>
#include <algorithm>
#include <string>

bool isPalindrome(int x) {
  std::string numberString = std::to_string(x);
  std::string reversedString = numberString;
  std::reverse(reversedString.begin(), reversedString.end());
  return numberString == reversedString;
}

int main() {
  std::cout << "\n\n\n" << isPalindrome(121);
  std::cout << isPalindrome(212);
  std::cout << isPalindrome(98) << "\n\n\n";
  return 0;
}
