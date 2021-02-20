using System;
using System.Collections.Generic;
using System.Text;

namespace rr_cli
{
    public class Game
    {
        public string name;
        private GameSpace gs;
        private int buyinCost;
        private int baseCost;
        private int pot;
        private Reward reward;

        public Game(string name, int buyinCost, int baseCost, Reward reward)
        {
            this.name = name;
            this.buyinCost = buyinCost;
            this.baseCost = baseCost;
            this.reward = reward;
            this.gs = new GameSpace();
            this.pot = 0;
        }

        public void AddRat(Rat rat)
        {
            this.gs.AddRat(rat);
        }

        public int GetRatLocation(Rat rat)
        {
            return this.gs.GetRatLocation(rat);
        }

        public void RunBasicAction(Rat rat)
        {
            BasicAction action = new BasicAction(rat, this.gs);
            action.Execute();
        }
    }
}
