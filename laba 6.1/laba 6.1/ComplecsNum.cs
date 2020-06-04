using System;
using System.Collections.Generic;
using System.Text;

namespace laba_6._1
{
    class ComplecsNum : Number
    {
        double left2;
        double right2;

        public ComplecsNum(double left, double right, double left2, double right2)
        {
            this.left = left;
            this.right = right;
            this.left2 = left2;
            this.right2 = right2;

        }
        public override void addNum()
        {
            Console.WriteLine((left + left2) + " + " + (right + right2) + "i");
        }

        public override void divideNum()
        {
            Console.WriteLine(((left * left2) + (right * right2)) / ((left2 * left2) + (right2 * right2)) + " + " + ((right * left2) - (left * right2)) / ((left2 * left2) + (right2 * right2)) + "i");
        }

        public override void minusNum()
        {
            Console.WriteLine((left - left2) + " + " + (right - right2) + "i");
        }

        public override void multiNum()
        {
            Console.WriteLine(((left * left2) - (right * right2)) + " + " + ((left * right2) + (right * left2)) + "i");
        }
    }
}
