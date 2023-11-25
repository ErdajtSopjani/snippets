#include <iostream>
#include <string>

int strStr(std::string haystack, std::string needle) {
   for (int i = 0; i <= haystack.length() - needle.length(); i++) {
       if (haystack.substr(i, needle.length()) == needle) {
           return i;
       }
   }
   return -1;
}

int main() {
   std::string haystack[] = {"bassadbas", "sleetcodes", "github"};
   std::string needle[] = {"sad", "leetcode", "ggithub"};

   std::cout << strStr(haystack[0], needle[0]) << std::endl;
   std::cout << strStr(haystack[1], needle[1]) << std::endl;
   std::cout << strStr(haystack[2], needle[2]) << std::endl;

   return 0;
}
