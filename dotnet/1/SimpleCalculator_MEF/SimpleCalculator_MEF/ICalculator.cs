﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_MEF
{
    interface ICalculator
    {
        String Calculate(String input, Operation operation);
    }
}
