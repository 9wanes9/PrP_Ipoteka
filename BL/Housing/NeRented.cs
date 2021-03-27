using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Housing
{
    public class NeRented: House
    {
        public override double getIndex()
        {
            return base.getIndex() * 0.3;
        }
    }
}
