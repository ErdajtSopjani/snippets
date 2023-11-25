using System;

namespace LongestCommonPrefix {

    class Program {

        static void Main() {
            string[] strs = {"flower","flow","flight"};
            if(LongestCommonPrefix(strs) == "fl")
                Console.WriteLine($"\n\n\n\nCorrect {LongestCommonPrefix(strs)}\n\n");
            else 
                Console.WriteLine($"\n\n\n\nIncorrect {LongestCommonPrefix(strs)}\n\n");
        }

        public static string LongestCommonPrefix(string[] strs) {
            if (strs == null || strs.Length == 0)
                return "";

            char firstChar = strs[0][0];
            char currentChar = firstChar;
            string result = $"{currentChar}";
            int x = 0;

            for (int i = 1; i < strs.Length; i++) {
                if (firstChar != strs[i][0]) 
                    return string.Empty;
                if (x < strs[i].Length)
                    x++;
                currentChar = strs[0][x];

                if (currentChar == strs[i][x])
                    result+=currentChar;
                else 
                    break;
            }

            return result;
        }
    }
}
