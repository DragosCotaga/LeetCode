namespace DefaultNamespace;

public class Solution {
    public int LongestPalindrome(string s) {
        HashSet<char> set = new HashSet<char>();
        int longestPalindrome = 0;
        
        foreach (char c in s) {
            if (set.Contains(c)) {
                set.Remove(c);
                longestPalindrome += 2;
            } else {
                set.Add(c);
            }
        }
        
        if (set.Count > 0) {
            longestPalindrome += 1;
        }
        
        return longestPalindrome;
    }
}
