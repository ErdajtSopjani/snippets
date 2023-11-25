#include <iostream>
#include <vector>
#include <string>

std::string longestCommonPrefix(std::vector<std::string> strs) {
   if (strs.empty())
       return "";

   std::string prefix = strs[0];
   for (int i = 1; i < strs.size(); i++) {
       while (strs[i].find(prefix) != 0) {
           prefix = prefix.substr(0, prefix.length() - 1);
       }
   }

   return prefix;
}

int main() {
   std::vector<std::string> strs = {"flower", "flow", "flight"};
   std::cout << "\n\n\n\nCorrect " << longestCommonPrefix(strs) << "\n\n";
   return 0;
}
