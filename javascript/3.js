function longestCommonPrefix(strs) {
   if (!strs.length)
       return "";

   let prefix = strs[0];
   for (let i = 1; i < strs.length; i++) {
       while (strs[i].indexOf(prefix) !== 0) {
           prefix = prefix.substring(0, prefix.length - 1);
       }
   }

   return prefix;
}

let strs = ["flower", "flow", "flight"];
console.log("\n\n\n\nCorrect " + longestCommonPrefix(strs) + "\n\n");
 