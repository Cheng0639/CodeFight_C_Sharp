using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFights
{
    public partial class Chanllge_Of_The_Week
    {
        public static int brothersInTheBar(int[] glasses)
        {
            int count = 0;
            int index = 0;
            var list = new List<int>(glasses);
            while (index < list.Count - 2 && list.Count > 2)
            {
                if (list.Skip(index).Take(3).Distinct().Count() == 1)
                {
                    list.RemoveRange(index, 3);
                    count += 1;
                    index = Math.Max(0, index - 2);
                }
                else
                {
                    index++;
                }
            }

            return count;
        }
    }
}