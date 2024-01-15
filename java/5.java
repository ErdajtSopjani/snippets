public class Solution {
  public static boolean isPalindrome(int x) {
    String numberString = Integer.toString(x);
    String reversedString = new StringBuilder(numberString).reverse().toString();
    return numberString.equals(reversedString);
  }

  public static void main(String[] args) {
    System.out.println("\n\n\n" + isPalindrome(121));
    System.out.println(isPalindrome(212));
    System.out.println(isPalindrome(98) + "\n\n\n");
  }
}
