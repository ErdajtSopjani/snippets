public class Solution {

    static void Main(string[] args) {
        
        int[] nums = {3, 2, 4};
        int target = 6;
        int[] output = TwoSum(nums, target);

        foreach (int num in output) {
            Console.Write(num + " ");
        }
        
        Console.Read();
    }

    public static int[] TwoSum(int[] nums, int target) {

        int[] output = new int[2];

        for(int i = 0; i < nums.Count(); i++) {
            for(int y = i + 1; y < nums.Count(); y++) {
                if(nums[i] + nums[y] == target) {
                    output[0] = i;
                    output[1] = y;
                }
            }
        }

        return output;
    }
}
