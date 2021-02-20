using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace rr_cli
{
    public class GameSpace
    {
        private ObservableCollection<Rat> rq;
        public GameSpace()
        {
            this.rq = new ObservableCollection<Rat>();

        }
        internal void AddRat(Rat rat)
        {
            // todo :: validate to make sure we are allowed to add rat. 
            if (!rat.isBusy)
            {
                this.rq.Add(rat);
                rat.isBusy = true;
            }
            else
            {
                Console.WriteLine("rat not added to game, rat is busy!");
            }
        }

        internal int GetRatLocation(Rat rat)
        {
            int index = this.rq.IndexOf(rat);
            return index;
        }

        internal void MoveRat(Rat rat, int n)
        {
            // moves rat n spaces up the queue
            int index = this.GetRatLocation(rat);
            int newIndex = index - n >= 0 ? index - n : 0;
            this.rq.Move(index, newIndex);
        }

        internal void SwapRats(Rat rat, Rat other_rat )
        {
            // swaps two rats
        }
    }
}
