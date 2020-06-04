using System;
using System.Collections.Generic;
using System.Text;

namespace laba_6._1
{
    class DoubleNum : Number
    {
        public DoubleNum(double left, double right)
        {
            this.left = left;
            this.right = right;

        }
        public override void addNum()
        {
            Console.WriteLine((left) + (right));
        }

        public override void divideNum()
        {
            Console.WriteLine((left) / (right));
        }

        public override void minusNum()
        {
            Console.WriteLine((left) - (right));
        }

        public override void multiNum()
        {
            Console.WriteLine((left) * (right));
        }
    }

}
