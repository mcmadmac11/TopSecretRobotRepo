﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public interface IChangeTemperature
    {
        int coolDown { get; set; }
        int heatUp { get; set; }

    }
}
