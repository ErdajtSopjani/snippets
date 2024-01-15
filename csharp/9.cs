public class Solution {

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
      else if (character != ' ' || hasSign || hasNumber)
        break; 
    }

    return num * sign;
  }
};
