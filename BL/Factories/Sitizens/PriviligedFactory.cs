using BL.Interfaces;
using BL.Sitizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Factories.Sitizens
{
    public class PriviligedFactory : ISitizen
    {
        public Sitizen Create()
        {
            return new Privilegie();
        }
    }
}
