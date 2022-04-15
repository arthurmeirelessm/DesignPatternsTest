﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal interface IAircraft
    {
        void CheckWind();
        void GetCargo();
        void StartRoute(int wind);
    }
}
