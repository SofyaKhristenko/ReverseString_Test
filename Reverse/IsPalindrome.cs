using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class IsPalindrome
    {
        public bool IsPalindrom(int x)
        {
            if (x == 0) { return true; }
            if (x < 0 || x % 10 == 0) { return false; }

            int remain;
            int previousX = 0;
            int halfNum = 0;
            while (x > halfNum)
            {
                remain = x % 10;
                previousX = x;
                x = x / 10;
                halfNum = halfNum * 10 + remain;
            }

            if (x == halfNum || previousX == halfNum)
                return true;
            else
                return false;
        }

    }
}

