using System;

public class Solution {

  public static int LongestArithSeqLength(int[] nums) {
    int maxLength = 0;

    for (int i = 0; i < nums.Length; i++) {
      for (int y = i+1; y < nums.Length; y++) {
        int diff = nums[y] - nums[i];
        int lastNum = nums[y];
        int count = 2;
        
        for (int k = y+1; k < nums.Length; k++) {
          if (nums[k] - lastNum == diff) {
            lastNum = nums[k];
            count++;
          }
        }
        maxLength = Math.Max(maxLength, count);
      }
    }
  
    return maxLength;
  }
}
