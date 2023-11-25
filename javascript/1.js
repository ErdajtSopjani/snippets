function strStr(haystack, needle) {
   for (let i = 0; i <= haystack.length - needle.length; i++) {
       if (haystack.substring(i, i + needle.length) === needle) {
           return i;
       }
   }
   return -1;
}

let haystack = ["bassadbas", "sleetcodes", "github"];
let needle = ["sad", "leetcode", "ggithub"];

console.log(strStr(haystack[0], needle[0]));
console.log(strStr(haystack[1], needle[1]));
console.log(strStr(haystack[2], needle[2]));
 