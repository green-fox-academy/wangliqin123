using System.Collections.Generic;
using System.Linq;

namespace OddAvg
{
    public class OddAvgClass
    {
        public double OddAverage(List<int> numbers)
        {
            if (numbers == null)
            {
                return 1;
            }
            else if (numbers.Count != 0)
            {
                List<int> odd = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        odd.Add(i);
                    }
                }
                double average = odd.Average();
                return average;
            }
            return 0;    
        }
    }
}