using System;
using System.Collections.Generic;
using System.Text;

namespace rr_cli
{
    public class EqualReward : Reward
    {
        public override float GetReward(int n)
        {
            return this.Pot / this.Length;
        }
    }
}
