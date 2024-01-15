public class Solution {
  
  public static int longestArithSeqLength(int[] nums) {
    int maxLength = 0;

    for (int i = 0; i < nums.length; i++) {
      for (int y = i+1; y < nums.length; y++) {
        int diff = nums[y] - nums[i];
        int lastNum = nums[y];
        int count = 2;

        for (int k = y+1; k < nums.length; k++) {
          if (nums[k] - lastNum == diff) {
            lastNum = nums[k];
            count++;
          }
        }
        maxLength = Math.max(maxLength, count);
      }
    }

    return maxLength;
   }
}
