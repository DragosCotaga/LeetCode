namespace DefaultNamespace;

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;
        while (left < right) {
            int middle = left + (right - left) / 2;
            if (IsBadVersion(middle)) {
                right = middle;
            } else {
                left = middle + 1;
            }
        }
        return left;
    }
}
