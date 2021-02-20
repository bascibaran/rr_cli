namespace rr_cli
{
    public abstract class ClientCommand
    {
        public ModelEnum modelEnum;
        public string arg0;
        public string arg1;
        public abstract void Execute(Server s);
    }
}