public class Solution {

    static void Main(string[] args) {

        int[] nums = {1, 3, 5, 6};
        int target = 5;

        int output = SearchInsert(nums, target);
        System.Console.WriteLine($"\n\n{output}\n\n");

        Console.Read();
    }

    public static int SearchInsert(int[] nums, int target) {
        int output = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] >= target) {
                output = i;
                break;
            }
        }

        if(nums[nums.Length - 1] < target) {
            output = nums.Length;
        }

        return output;
    }
}
