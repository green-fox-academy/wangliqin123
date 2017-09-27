using System.Collections.Generic;
using System.Linq;

namespace Sum
{
    public class SumNumb
    {
        public int SumElements(List<int> inputNumbers)
        {
            if (inputNumbers != null)
            {
                return inputNumbers.Sum();
            }
            else
            {
                return 10;
            }
        }
    }
}