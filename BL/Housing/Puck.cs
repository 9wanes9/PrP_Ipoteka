using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Housing
{
    public class Puck: House
    {
        public override double getIndex()
        {
            return base.getIndex() * 1.8;
        }
    }
}
