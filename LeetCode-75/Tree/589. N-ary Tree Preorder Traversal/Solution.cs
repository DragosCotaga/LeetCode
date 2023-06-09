﻿namespace DefaultNamespace;

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        List<int> result = new List<int>();
        if (root == null) {
            return result;
        }
        result.Add(root.val);
        foreach (Node child in root.children) {
            result.AddRange(Preorder(child));
        }
        return result;
    }
}
