using System;
using System.Collections.Generic;
using System.Text;

namespace laba_6._1
{
    class IntegersNum : Number
    {
        public IntegersNum(double left, double right)
        {
            this.left = left;
            this.right = right;

        }
        public override void addNum()
        {
            Console.WriteLine((int)(left) + (int)(right));
        }

        public override void divideNum()
        {
            Console.WriteLine((int)(left) / (int)(right));
        }

        public override void minusNum()
        {
            Console.WriteLine((int)(left) - (int)(right));
        }

        public override void multiNum()
        {
            Console.WriteLine((int)(left) * (int)(right));
        }
    }

}
