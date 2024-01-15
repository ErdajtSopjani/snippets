using System;

namespace FindIndexOfOccurrance {
  class Program {
    static void Main() {
      string[] haystack = {"bassadbas", "sleetcodes", "github"};
      string[] needle = {"sad", "leetcode", "ggithub"};

      Console.WriteLine(StrStr(haystack[0], needle[0]));
      Console.WriteLine(StrStr(haystack[1], needle[1]));
      Console.WriteLine(StrStr(haystack[1], needle[1]));
    }

    public static int StrStr(string haystack, string needle) {
      for (int i = 0; i < haystack.Length - needle.Length; i++) {
         if (haystack.Substring(i, needle.Length) == needle) return i;
      }
        
      return -1;
    }
  }  
}
