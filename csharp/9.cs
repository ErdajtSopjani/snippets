public class Solution {

    static void Main(string[] args) {

        System.Console.WriteLine("\n\n\n" + MyAtoi("421 with words"));
        System.Console.WriteLine(MyAtoi("421 with words"));
        System.Console.WriteLine(MyAtoi("-421"));
        System.Console.WriteLine(MyAtoi("42-1"));
        System.Console.WriteLine(MyAtoi(" yesyes 42-1") + "\n\n\n");

        Console.Read();
    }

    public static int MyAtoi(string s) {
        int num = 0;
        int sign = 1;
        bool hasSign = false;
        bool hasNumber = false;

        foreach (char character in s) {
            if(char.IsDigit(character)) {
                int digit = character - '0';
                if (num > Int32.MaxValue / 10 || (num == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10)) {
                    return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                }
                num = num * 10 + digit;
                hasNumber = true;
            }
            else if (!hasSign && !hasNumber && (character == '+' || character == '-')) {
                hasSign = true;
                sign = character == '+' ? 1 : -1;
            }
            else if (character != ' ' || hasSign || hasNumber) {
                break; 
            }
        }

        return num * sign;
    }
};
