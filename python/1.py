def str_str(haystack, needle):
    for i in range(len(haystack) - len(needle) + 1):
        if haystack[i:i+len(needle)] == needle:
            return i
    return -1

haystack = ["bassadbas", "sleetcodes", "github"]
needle = ["sad", "leetcode", "ggithub"]

print(str_str(haystack[0], needle[0]))
print(str_str(haystack[1], needle[1]))
print(str_str(haystack[2], needle[2]))
