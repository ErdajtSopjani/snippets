public class Solution {

    static void Main(string[] args) {
        
        System.Console.WriteLine("\n\n"+Reverse(12356));
        System.Console.WriteLine(Reverse(0));
        System.Console.WriteLine(Reverse(0987654321)+"\n\n");

        Console.Read();
    }

    public static int Reverse(int x) {
        if (x == int.MinValue) {
            return 0;
        }

        bool isNegative = x < 0;
        string str = Math.Abs(x).ToString();

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);

        if (int.TryParse(reversedStr, out int result)) {
            return isNegative ? -result : result;
        }

        return 0;
    }
}
