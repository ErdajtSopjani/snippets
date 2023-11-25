function longestArithSeqLength(nums) {
   let maxLength = 0;

   for (let i = 0; i < nums.length; i++) {
       for (let y = i+1; y < nums.length; y++) {
           let diff = nums[y] - nums[i];
           let lastNum = nums[y];
           let count = 2;

           for (let k = y+1; k < nums.length; k++) {
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

let nums = [3, 6, 9, 12, 1231412];
console.log("The longest Arithmetic Subsequence in `nums` is: " + longestArithSeqLength(nums));

let nums2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
console.log("The longest Arithmetic Subsequence in `nums2` is: " + longestArithSeqLength(nums2));
 