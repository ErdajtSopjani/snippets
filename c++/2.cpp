#include <iostream>
#include <vector>
#include <algorithm>

int longestArithSeqLength(std::vector<int> nums) {
   int maxLength = 0;

   for (int i = 0; i < nums.size(); i++) {
       for (int y = i+1; y < nums.size(); y++) {
           int diff = nums[y] - nums[i];
           int lastNum = nums[y];
           int count = 2;

           for (int k = y+1; k < nums.size(); k++) {
               if (nums[k] - lastNum ==```
