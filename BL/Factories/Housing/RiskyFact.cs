using BL.Housing;
using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Factories.Housing
{
    public class RiskyFact: IHousing
    {
        public House Create()
        {
            return new Puck();
        }
    }
}
