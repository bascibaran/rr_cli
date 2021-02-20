namespace rr_cli
{
    internal class ClientListCommand : ClientCommand
    {
        public override void Execute(Server s)
        {
            switch (this.modelEnum)
            {
                case ModelEnum.GAME:
                    s.ListGames();
                    break;
                case ModelEnum.RAT:
                    s.ListRats();
                    break;
            }
        }
    }
}