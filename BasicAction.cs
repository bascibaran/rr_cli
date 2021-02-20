using System;
using System.Collections.Generic;
using System.Text;

namespace rr_cli
{
    public class BasicAction : GameAction
    {
        public BasicAction( Rat rat, GameSpace gs)
        {
            this.type = GameActionType.DETERMINISTIC;
            this.rat = rat;
            this.gs = gs;
        }
        public override void Execute()
        {
            this.gs.MoveRat(this.rat, 1);            
        }
    }
}
