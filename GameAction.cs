namespace rr_cli
{
    public abstract class GameAction
    {
        public GameActionType type;

        public Rat rat;

        public GameSpace gs;

        public abstract void Execute();
    }
}