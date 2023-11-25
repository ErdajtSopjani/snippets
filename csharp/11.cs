public class Solution {

    static void Main(string[] args) {
        
        int[] numbers = {2, 7, 11, 15};
        int target = 9;

        int[] output = TwoSum(numbers, target);
        foreach (int i in output) {
            Console.WriteLine(i);
        }

        Console.Read();
    }

    public static int[] TwoSum(int[] numbers, int target) {
        int[] output = new int[2];
        HashSet<int> visitedNumbers = new HashSet<int>();

        for (int i = 0; i < numbers.Length; i++) {
            int complement = target - numbers[i];

            if (visitedNumbers.Contains(complement)) {
                output[0] = Array.IndexOf(numbers, complement) + 1;
                output[1] = i + 1;
                break;
            }

            visitedNumbers.Add(numbers[i]);
        }

        return output;
    }
}
