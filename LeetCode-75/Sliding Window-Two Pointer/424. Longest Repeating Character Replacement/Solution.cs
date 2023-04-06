namespace DefaultNamespace;

public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int maxCount = 0;
        int maxLength = 0;
        int start = 0;
        
        for(int end = 0; end < s.Length; end++) {
            count[s[end] - 'A']++;
            maxCount = Math.Max(maxCount, count[s[end] - 'A']);
            
            if(end - start + 1 - maxCount > k) {
                count[s[start] - 'A']--;
                start++;
            }
            
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
}
