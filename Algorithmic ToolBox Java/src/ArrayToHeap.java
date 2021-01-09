import java.util.ArrayList;
import java.util.Scanner;

public class ArrayToHeap {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = scanner.nextInt();
        }
        Heap heap = new Heap(n);
        heap.BuildHeap(nums);
        System.out.println(heap.swaps.size());
        for (int i = 0; i < heap.swaps.size(); i++)
        {
            Swap swap = heap.swaps.get(i);
            System.out.println(swap.index1 + " " + swap.index2);
        }
    }
}

class Heap
{
    private int[] data;
    public int size;
    public int max_size;
    public ArrayList<Swap> swaps;

    public Heap(int n)
    {
        data = new int[n];
        max_size = n;
        swaps = new ArrayList<Swap>();
    }

    public void BuildHeap(int[] A)
    {
        int size = A.length;
        data = A;
        for (int i = 0; i <= size / 2; i++)
            ShiftDown(i);
    }

    public int Parent(int i)
    {
        return data[i / 2];
    }

    public int LeftChild(int i)
    {
        return data[2 * i];
    }

    public int RightChild(int i)
    {
        return data[2 * i + 1];
    }

    public void ShiftUp(int i)
    {
        while (i > 1 && Parent(i) < data[i])
        {
            int temp = Parent(i);
            data[i / 2] = data[i];
            data[i] = temp;
            i = i / 2;
        }
    }

    public void ShiftDown(int i)
    {
        int maxIndex = i;
        int l = i * 2 - 1;
        if (i == 0)
            l = 1;
        if (l < data.length && data[l] < data[maxIndex])
            maxIndex = l;
        int r = i * 2;
        if (i == 0)
            r = 2;
        if (r < data.length && data[r] < data[maxIndex])
            maxIndex = r;
        if (i != maxIndex)
        {
            int temp = data[i];
            data[i] = data[maxIndex];
            data[maxIndex] = temp;
            swaps.add(new Swap(i, maxIndex));
            ShiftDown(maxIndex);
        }
    }

    public int ExtractMax()
    {
        int result = data[0];
        data[0] = data[data.length - 1];
        size--;
        ShiftDown(0);
        return result;
    }
}

class Swap
{
    public int index1;
    public int index2;

    public Swap(int index1, int index2)
    {
        this.index1 = index1;
        this.index2 = index2;
    }
}
