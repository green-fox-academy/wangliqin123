using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommon
{
    class MostCommonWord
    {
        static void Main(string[] args)
        {
            Words words = new Words();

            if (args.Length == 0)
            {
                words.Usage();
            }
            else
            {
                words.CountCommonWords();
            }
        }
    }
}
