namespace DefaultNamespace;

public class Solution
{
    public class Solution {
        public int PivotIndex(int[] nums) {
            // Calculate the sum of all elements in the array
            int sum = 0;
            foreach (int num in nums) {
                sum += num;
            }
        
            // Initialize the running sum of elements to the left
            int leftSum = 0;
            // Iterate through the array to find the pivot index
            for (int i = 0; i < nums.Length; i++) {
                // Check if the left sum is equal to the right sum
                if (leftSum == sum - leftSum - nums[i]) {
                    return i;
                }
                // Add the current element to the left sum
                leftSum += nums[i];
            }
        
            // No pivot index found, return -1
            return -1;
        }
    }

}