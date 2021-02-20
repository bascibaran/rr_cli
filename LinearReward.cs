using System;
using System.Collections.Generic;
using System.Text;

namespace rr_cli
{
    class LinearReward : Reward
    {
        public override float GetReward(int n)
        {
            float width = 1 / this.Length;
            float x = (n + 1) * width;
            float height = 2 * this.Pot - ((2 * this.Pot) * x);
            float area = height * width;
            return area;
        }
    }
}
