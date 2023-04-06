namespace DefaultNamespace;

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> result = new List<int>();
        int[] freqP = new int[26];
        int[] freqS = new int[26];
        int lenP = p.Length;
        int lenS = s.Length;
        
        // count the frequency of characters in p
        foreach(char c in p) {
            freqP[c - 'a']++;
        }
        
        // sliding window
        for(int i = 0; i < lenS; i++) {
            // add current character to frequency array
            freqS[s[i] - 'a']++;
            
            // remove first character from frequency array
            if(i >= lenP) {
                freqS[s[i-lenP] - 'a']--;
            }
            
            // check if frequency arrays are equal
            if(i >= lenP - 1 && IsEqual(freqS, freqP)) {
                result.Add(i - lenP + 1);
            }
        }
        
        return result;
    }
    
    private bool IsEqual(int[] freqS, int[] freqP) {
        for(int i = 0; i < 26; i++) {
            if(freqS[i] != freqP[i]) {
                return false;
            }
        }
        return true;
    }
}
