using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Sitizens
{
    public class Old : Sitizen
    {
        public override double getRate()
        {
            return base.getRate() * 1.75;
        }
    }
}
