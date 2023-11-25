fn longest_arith_seq_length(nums: &[i32]) -> i32 {
   let mut max_length = 0;

   for i in 0..nums.len() {
       for y in (i+1)..nums.len() {
           let diff = nums[y] - nums[i];
           let last_num = nums[y];
           let mut count = 2;

           for k in (y+1)..nums.len() {
               if nums[k] - last_num == diff {
                  last_num = nums[k];
                  count += 1;
               }
           }
           max_length = max_length.max(count);
       }
   }

   max_length
}

fn main() {
   let nums = [3, 6, 9, 12, 1231412];
   println!("The longest Arithmetic Subsequence in `nums` is: {}", longest_arith_seq_length(&nums));

   let nums2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
   println!("The longest Arithmetic Subsequence in `nums2` is: {}", longest_arith_seq_length(&nums2));
}
 