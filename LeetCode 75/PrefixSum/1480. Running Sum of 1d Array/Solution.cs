namespace DefaultNamespace;

public class Solution {
    public int[] RunningSum(int[] nums) {
        // Iterate through the array starting from the second element
        for (int i = 1; i < nums.Length; i++) {
            // Add the previous element to the current element
            nums[i] += nums[i-1];
        }
        // Return the modified array
        return nums;
    }
}
