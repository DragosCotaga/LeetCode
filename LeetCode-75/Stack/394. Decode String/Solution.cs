namespace DefaultNamespace;

public class Solution {
    public string DecodeString(string s) {
        var stack = new Stack<(int, string)>();
        int repeatCount = 0;
        string decodedString = "";

        foreach (char c in s) {
            if (Char.IsDigit(c)) {
                repeatCount = repeatCount * 10 + (c - '0');
            } else if (Char.IsLetter(c)) {
                decodedString += c;
            } else if (c == '[') {
                stack.Push((repeatCount, decodedString));
                repeatCount = 0;
                decodedString = "";
            } else if (c == ']') {
                (int prevRepeatCount, string prevDecodedString) = stack.Pop();
                decodedString = prevDecodedString + String.Concat(Enumerable.Repeat(decodedString, prevRepeatCount));
            }
        }

        return decodedString;
    }

}