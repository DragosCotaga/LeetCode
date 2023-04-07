namespace DefaultNamespace;

public class Solution {
    public string GetHint(string secret, string guess) {
        int bulls = 0;
        int cows = 0;
        int[] freq = new int[10];
        
        for(int i = 0; i < secret.Length; i++) {
            if(secret[i] == guess[i]) {
                bulls++;
            } else {
                freq[secret[i] - '0']++;
            }
        }
        
        for(int i = 0; i < guess.Length; i++) {
            if(secret[i] != guess[i] && freq[guess[i] - '0'] > 0) {
                cows++;
                freq[guess[i] - '0']--;
            }
        }
        
        return $"{bulls}A{cows}B";
    }
}
