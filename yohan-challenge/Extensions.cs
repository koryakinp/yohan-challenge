using System;
using System.Collections.Generic;
using System.Text;

namespace yohan_challenge
{
    public static class Extensions
    {
        public static int GetOrderOfMagnitude(this int input)
        {
            return (int)Math.Floor(Math.Log10(input)) + 1;
        }
    }
}
