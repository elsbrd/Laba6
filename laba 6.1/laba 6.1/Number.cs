using System;
using System.Collections.Generic;
using System.Text;

namespace laba_6._1
{
    abstract class Number
    {
        public double left;
        public double right;

        public abstract void addNum();
        public abstract void minusNum();
        public abstract void divideNum();
        public abstract void multiNum();
    }

}
