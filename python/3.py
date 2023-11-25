def longest_common_prefix(strs):
   if not strs:
       return ""

   first_str = strs[0]
   for i in range(1, len(strs)):
       while not strs[i].startswith(first_str):
           first_str = first_str[:-1]

   return first_str

strs = ["flower","flow","flight"]
print(f"\n\n\n\nCorrect {longest_common_prefix(strs)}\n\n")
