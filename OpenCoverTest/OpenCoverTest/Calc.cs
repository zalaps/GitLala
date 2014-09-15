using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverTest
{
    public class Calc
    {
        public int DoAdd(int a, int b)
        {
            int r;
            if (a > 0 && b > 0)
            {
                r = a + b;
            }
            else
            {
                throw new ArgumentException("some message...");
            }                
            return r;
        }

        public int DoSub(int a, int b)
        {
            int r;
            if (a > 0 && b > 0)
            {
                r = a - b;
            }
            else
            {
                throw new ArgumentException("some messsssage...");
            }
            return r;
        }
    }
}
