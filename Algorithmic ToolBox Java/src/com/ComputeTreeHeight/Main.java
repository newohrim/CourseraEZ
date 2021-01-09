package com.ComputeTreeHeight;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String args[])
    {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        Node[] tree = new Node[n];
        int rootIndex;
        Node root = null;
        for(int i = 0; i < n; i++)
        {
            int nodeNumber = scanner.nextInt();
            if (nodeNumber == -1)
            {
                rootIndex = i;
                tree[i] = new Node();
                root = tree[i];
                continue;
            }
            if (tree[nodeNumber] == null)
                tree[nodeNumber] = new Node();
            if (tree[i] == null)
                tree[i] = new Node();
            tree[nodeNumber].children.add(tree[i]);
        }
        System.out.println(root.Height());
    }
}

class Node
{
    public ArrayList<Node> children;

    public Node()
    {
        children = new ArrayList<Node>();
    }

    public int Height()
    {
        if (children.size() == 0)
            return 1;
        else
            return 1 + MaxHeight(children);
    }

    private int MaxHeight(ArrayList<Node> nodes)
    {
        int max = 0;
        for(int i = 0; i < nodes.size(); i++)
            if (nodes.get(i).Height() > max)
                max = nodes.get(i).Height();
        return max;
    }
}
