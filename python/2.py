def longest_arith_seq_length(nums):
    max_length = 0

    for i in range(len(nums)):
     for y in range(i+1, len(nums)):
         diff = nums[y] - nums[i]
         last_num = nums[y]
         count = 2
    
         for k in range(y+1, len(nums)):
             if nums[k] - last_num == diff:
                 last_num = nums[k]
                 count += 1
         max_length = max(max_length, count)
    
    return max_length

nums = [3, 6, 9, 12, 1231412]
print(f"The longest Arithmetic Subsequence in `nums` is: {longest_arith_seq_length(nums)}")

nums2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]
print(f"The longest Arithmetic Subsequence in `nums2` is: {longest_arith_seq_length(nums2)}")
