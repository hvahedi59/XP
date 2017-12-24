using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateApp
{
    public class Calculator3
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int ConvertUSDtoGBP(ICurencyConverter3 feed, int USDValue)
        {
            return feed.GetGBPRate();
        }

    }
}