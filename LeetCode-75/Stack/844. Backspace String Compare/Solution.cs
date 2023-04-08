namespace DefaultNamespace;

public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var sStack = new Stack<char>();
        var tStack = new Stack<char>();

        foreach (char c in s) {
            if (c == '#' && sStack.Count > 0) {
                sStack.Pop();
            } else if (c != '#') {
                sStack.Push(c);
            }
        }

        foreach (char c in t) {
            if (c == '#' && tStack.Count > 0) {
                tStack.Pop();
            } else if (c != '#') {
                tStack.Push(c);
            }
        }

        return sStack.SequenceEqual(tStack);
    }

}