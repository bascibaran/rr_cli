namespace rr_cli
{
    internal class ClientCreateCommand : ClientCommand
    {
        
        public override void Execute(Server s)
        {
            switch (this.modelEnum)
            {
                case ModelEnum.GAME:
                    s.CreateGame(this.arg0);
                    break;
                case ModelEnum.RAT:
                    s.CreateRat(this.arg0);
                    break;
            }
        }
    }
}