﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IvanAkcheurov.NClassify
{
    public interface IDistanceCalculator<T>
    {
        double CalculateDistance(T obj1, T obj2);
    }
}