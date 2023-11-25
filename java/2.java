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

   public static void main(String[] args) {
       int[] nums = {3, 6, 9, 12, 1231412};
       System.out.println("The longest Arithmetic Subsequence in `nums` is: " + longestArithSeqLength(nums));

       int[] nums2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
       System.out.println("The longest Arithmetic Subsequence in `nums2` is: " + longestArithSeqLength(nums2));
   }
}
