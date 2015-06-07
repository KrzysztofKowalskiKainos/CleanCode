﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface IStatusable
    {
        IEnumerable<string> GetPlayerStatus(string player);
    }
}
