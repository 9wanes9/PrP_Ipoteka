using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Housing.Factories
{
    public class NotRentedFact : IHousing
    {
        public House Create()
        {
            return new NeRented();
        }
    }
}
