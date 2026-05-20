public class Solution {
    public int MyAtoi(string s) {
        int i = 0;
        var sign = 1;
        var result = 0;

        // Iterate through empty space
        while (i < s.Length) {
            if (s[i] != ' ') {
                break;
            }

            i++;
        }

        // Iterate through a single sign character.
        if (i < s.Length && s[i] == '-') {
           sign = -1;
           i++;
        }
        else if (i < s.Length && s[i] == '+') {
           i++;
        }

        // Iterate through leading zeros.
        while (i < s.Length) {
            if (s[i] != '0') {
                break;
            }

            i++;
        }

        // Iterate through digits until something else or end is reached.
        while (i < s.Length) {
            if (char.IsDigit(s[i]) == false) {
                break;
            }
            
            int digit = s[i] - '0';

            // If overflow would occur, return max value.
            if (result > (int.MaxValue - digit) / 10) {
                return int.MaxValue;
            }
            
            // If underflow would occur, return min value.
            if (result < (int.MinValue + digit) / 10) {
                return int.MinValue;
            }

            // Shift value by 1 and add digit.
            result = (result * 10) + (sign * digit);
            
            i++;
        }

        return result;
    }
}
