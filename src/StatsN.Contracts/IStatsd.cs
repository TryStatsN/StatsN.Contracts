﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsN
{
    public interface IStatsd : IStatsdAsync, IStatsdSync
    {
    }
}
