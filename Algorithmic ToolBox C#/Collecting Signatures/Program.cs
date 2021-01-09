using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collecting_Signatures
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Line> lines = new List<Line>();
            int minStart = int.MaxValue;
            int maxEnd = 0;
            for (int i = 0; i < n; i++) 
            {
                string[] data = Console.ReadLine().Split();
                int start = int.Parse(data[0]);
                int end = int.Parse(data[1]);
                lines.Add(new Line(start, end));
                if (start < minStart)
                    minStart = start;
                if (end > maxEnd) 
                    maxEnd = int.Parse(data[1]);
            }
            lines.Sort();
            for (int i = minStart; i <= maxEnd; i++) 
            {
                int maxIntersections = 0;
                int intersections = 0;
                for (int j = 0; j < n; j++) 
                {
                    if (i >= lines[j].Start && i <= lines[j].End)
                    {
                        intersections++;
                    }
                    else break;
                    if (intersections > maxIntersections)
                        maxIntersections = intersections;
                }
            }

            for (int i = 0; i < n; i++) 
            {
                int maxIntersections = 0;
                for (int j = lines[i].Start; j <= lines[i].End; j++) 
                {
                    int intersections = 0;
                    for (int k = 0; k < n; k++) 
                    {
                        if (j >= lines[k].Start && j <= lines[k].End) 
                        {
                            intersections++;
                        }
                    }
                }
            }
        }
    }

    class Line : IComparable
    {
        public int Start { get; set; }
        public int End { get; set; }
        public Line(int Start, int End) 
        {
            this.Start = Start;
            this.End = End;
        }
        public int CompareTo(object obj)
        {
            return Start.CompareTo(obj);
        }
    }
}
