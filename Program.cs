using System;

namespace rr_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Server s = new Server();
            InputParser p = new InputParser();
            string inputString;
            ClientCommand cmd;
            while (true)
            {
                Console.Write("rrcli:: ");
                inputString = Console.ReadLine();
                cmd = p.ParseCommandFromInput(inputString);
                s.RunCommand(cmd);                
            }
        }
    }
}
