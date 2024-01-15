public class Solution {

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
