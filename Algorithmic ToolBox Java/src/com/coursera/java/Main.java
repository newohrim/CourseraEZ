package com.coursera.java;

import java.util.Queue;
import java.util.Scanner;
import java.util.Stack;

public class Main {
    public static void main(String[] args) {
	    Scanner scanner = new Scanner(System.in);
	    String line = scanner.nextLine();
	    int status = IsBalanced(line);
        if (status == 0)
            System.out.println("Success");
        else
            System.out.println(status);
    }

    private static int IsBalanced(String line)
    {
        Stack<Integer> lastOpeningIndex = new Stack<Integer>();
        Stack<Character> brackets = new Stack<Character>();
        for(int i = 0; i < line.length(); i++)
        {
            if (line.charAt(i) == '(' || line.charAt(i) == '{' || line.charAt(i) == '[')
            {
                lastOpeningIndex.push(i + 1);
                brackets.push(line.charAt(i));
            }
            else if (line.charAt(i) == ')' || line.charAt(i) == '}' || line.charAt(i) == ']')
            {
                if (!lastOpeningIndex.empty())
                    lastOpeningIndex.pop();
                if (brackets.empty())
                    return i + 1;
                Character top = brackets.pop();
                if (top == null)
                    return i + 1;
                if (top == '[' && line.charAt(i) != ']'
                        || top == '(' && line.charAt(i) != ')'
                            || top == '{' && line.charAt(i) != '}')
                    return i + 1;
            }
        }
        if (brackets.empty())
            return 0;
        else
            return lastOpeningIndex.lastElement();
    }
}
