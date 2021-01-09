import java.util.Scanner;
import java.util.Stack;

public class ExtendingStack {
    public static void main(String args[])
    {
        ExtendedStack ExtStack = new ExtendedStack();
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        for(int i = 0; i < n; i++)
        {
            String command = scanner.next();
            switch (command)
            {
                case "push":
                    int value = scanner.nextInt();
                    ExtStack.Push(value);
                    break;
                case "pop":
                    ExtStack.Pop();
                    break;
                case "max":
                    System.out.println(ExtStack.Max.peek());
                    break;
            }
        }
    }
}

class ExtendedStack
{
    public Stack<Integer> Max = new Stack<Integer>();
    private Node Head;
    private Node Tail;

    public ExtendedStack()
    {
        Head = null;
        Tail = Head;
    }

    public void Push(int value)
    {
        if (Max.size() == 0 || value >= Max.peek())
            Max.push(value);
        if (Head == null)
            Head = new Node(value);
        else
        {
            Node temp = new Node(value);
            temp.next = Head;
            Head = temp;
        }
    }

    public int Pop()
    {
        if (Head == null)
            return -1;
        int result = Head.value;
        if (Max.size() != 0 && result == Max.peek())
            Max.pop();
        if (Head.next != null)
            Head = Head.next;
        else
            Head = null;
        return result;
    }
}

class Node
{
    public int value;
    public Node next;

    public Node(int value)
    {
        this.value = value;
    }
}
