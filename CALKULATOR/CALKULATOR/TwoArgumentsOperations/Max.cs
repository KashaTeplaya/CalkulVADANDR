﻿using CALKULATOR.OneArgumentsOperations;
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    public class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {

            return Math.Max(first, second);

        }
    }
}