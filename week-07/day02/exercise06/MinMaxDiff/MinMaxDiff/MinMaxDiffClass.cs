using System.Collections.Generic;
using System.Linq;

namespace MinMaxDiff
{
    public class MinMaxDiffClass
    {
        public int MinMaxDiff(List<int> inputNumbers)
        {
            if (inputNumbers == null)
            {
                return 1;
            }
            else if (inputNumbers.Count == 0)
            {
                return 0;
            }
            else
            {
                return inputNumbers.Max() - inputNumbers.Min();
            }
        }
    }
}