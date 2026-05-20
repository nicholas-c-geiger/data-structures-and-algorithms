public class Solution {
    public int Reverse(int x) {
        int result = 0;
        int sign = 1;
        
        if (x < 0) {
            sign = -1;
        }

        while (x != 0) {
            int digit = x % 10;

            if ((result > (int.MaxValue - Math.Abs(digit)) / 10)
                || (result < (int.MinValue + Math.Abs(digit)) / 10)) {
                return 0;
            }

            x /= 10;
            result = (result * 10) + digit;
        }

        return result;
    }
}
