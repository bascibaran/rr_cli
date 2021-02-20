namespace rr_cli
{
    public class ClientCommandBuilder
    {
        private ClientCommand cmd { get; set; }

        public void SetListCommand()
        {
            this.cmd = new ClientListCommand();
        }

        public void SetCreateCommand()
        {
            this.cmd = new ClientCreateCommand();
        }

        public void SetPlayCommand()
        {
            this.cmd = new ClientPlayCommand();
        }

        public void SetModelGame()
        {
            this.cmd.modelEnum = ModelEnum.GAME;
        }

        public void SetModelRat()
        {
            this.cmd.modelEnum = ModelEnum.RAT;
        }

        public void SetArg0(string arg)
        {
            this.cmd.arg0 = arg;
        }


        public void SetArg1(string arg)
        {
            this.cmd.arg1 = arg;
        }

        public ClientCommand BuildCommand()
        {
            return this.cmd;
        }


        

    }
}