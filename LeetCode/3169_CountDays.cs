using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _3169_CountDays
    {
        public int CountDays(int days, int[][] meetings)
        {
            if (meetings.Length == 0) return days;

            Array.Sort(meetings, (a, b) =>
            {
                int cmp = a[0].CompareTo(b[0]); 
                return cmp != 0 ? cmp : a[1].CompareTo(b[1]);
            });

            int busyDays = 0;
            int lastEnd = 0;

            foreach (var meeting in meetings)
            {
                int start = meeting[0];
                int end = meeting[1];

                if (start > lastEnd)
                {
                    busyDays += end - start + 1;
                }
                else if (end > lastEnd) 
                {
                    busyDays += end - lastEnd;
                }

                lastEnd = Math.Max(lastEnd, end);
            }

            
            return days - busyDays;
        }
    }
}
