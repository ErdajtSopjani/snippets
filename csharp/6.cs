using System;

namespace RemoveElement {

    class Program {

        static void Main() {

            int[] nums = {1, 2, 3, 4, 5, 1, 1, 1};
            int val = 1;
            RemoveElement(nums, val);
        }

        public static int RemoveElement(int[] nums, int val) {
            int times = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != val) {
                    nums[times] = nums[i];
                    times++;
                }
            }

            return times;
        }   
    }
}
