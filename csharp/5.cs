public class Solution {

    static void Main(string[] args) {
        
        System.Console.WriteLine("\n\n\n" + IsPalindrome(121));
        System.Console.WriteLine(IsPalindrome(212));
        System.Console.WriteLine(IsPalindrome(98) + "\n\n\n");

        Console.Read();
    }

    public static bool IsPalindrome(int x) {
        string numberString = x.ToString();
        string reversedString = new string(numberString.Reverse().ToArray());
        return numberString == reversedString;
    }
}
