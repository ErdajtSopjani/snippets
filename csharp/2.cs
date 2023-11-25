public class Solution {

    static void Main(string[] args) {

        int[] nums = {3, 6, 9, 12, 1231412};
        Console.WriteLine($"\n\n The longes Arithemtic Subsequence in `nums` is: {LongestArithSeqLength(nums)}");
        int[] nums2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
        Console.WriteLine($" The longes Arithemtic Subsequence in `nums2` is: {LongestArithSeqLength(nums2)}\n\n");

        Console.Read();
    }

    public static int LongestArithSeqLength(int[] nums) {
        
        int maxLength = 0;

        for (int i = 0; i < nums.Length; i++) {
            for (int y = i+1; y < nums.Length; y++) 
            {
                int diff = nums[y] - nums[i];
                int lastNum = nums[y];
                int count = 2;

                for (int k = y+1; k < nums.Length; k++) 
                {
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
