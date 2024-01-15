public class Main {
  public static int strStr(String haystack, String needle) {
    for (int i = 0; i <= haystack.length() - needle.length(); i++) {
      if (haystack.substring(i, i + needle.length()).equals(needle)) {
        return i;
      }
    }
    return -1;
  }

  public static void main(String[] args) {
    String[] haystack = {"bassadbas", "sleetcodes", "github"};
    String[] needle = {"sad", "leetcode", "ggithub"};

    System.out.println(strStr(haystack[0], needle[0]));
    System.out.println(strStr(haystack[1], needle[1]));
    System.out.println(strStr(haystack[2], needle[2]));
  }
}
