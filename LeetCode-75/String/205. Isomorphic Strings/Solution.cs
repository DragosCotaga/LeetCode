namespace DefaultNamespace;

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        var map = new Dictionary<char, char>();
    
        for (int i = 0; i < s.Length; i++) {
            if (!map.ContainsKey(s[i])) {
                if (map.ContainsValue(t[i])) return false;
                map[s[i]] = t[i];
            } else if (map[s[i]] != t[i]) {
                return false;
            }
        }
    
        map.Clear();
    
        for (int i = 0; i < t.Length; i++) {
            if (!map.ContainsKey(t[i])) {
                if (map.ContainsValue(s[i])) return false;
                map[t[i]] = s[i];
            } else if (map[t[i]] != s[i]) {
                return false;
            }
        }
    
        return true;
    }
}