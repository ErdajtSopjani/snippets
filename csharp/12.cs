public class Solution {

    static void Main(string[] args) {
        
        System.Console.WriteLine("\n\n\n" + IsValid("(((})))")); // false
        System.Console.WriteLine(IsValid("((()))")); // true
        System.Console.WriteLine(IsValid("(())[][][]{}")); // true
        System.Console.WriteLine(IsValid("{}[]()") + "\n\n\n"); // true


        Console.Read();
    }

    public static bool IsValid(string s) {
        Dictionary<char, char> dic = new Dictionary<char, char>() {
            {')', '(' },
            {'}', '{' },
            {']', '[' }
        };
        
        Stack<char> stack = new Stack<char>();

        foreach(char c in s) {
            if(dic.ContainsValue(c)) {
                stack.Push(c);
            } else if(dic.ContainsKey(c)) {
                if(stack.Count == 0 || stack.Pop() != dic[c]) {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}
