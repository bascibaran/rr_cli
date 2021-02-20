using System;

namespace rr_cli
{
    internal class InputParser
    {
        public InputParser()
        {
        }

        public ClientCommand ParseCommandFromInput(string inputString)
        {
            string[] tokens = inputString.Split(' ');

            ClientCommandBuilder cb = new ClientCommandBuilder();
            ClientCommand cmd;

            if (tokens.Length > 3)
            {
                Console.WriteLine("ERROR: UNRECOGNIZED COMMAND");
                return null;
            }

            switch (tokens[0])
            {
                case "list":
                    cb.SetListCommand();
                    break;
                case "create":
                    cb.SetCreateCommand();
                    break;
                case "play":
                    Console.WriteLine("TODO: IMPLEMENT PLAY COMMAND");
                    return null;
                    //break;
                default:
                    cmd = null;
                    Console.WriteLine("ERROR: UNRECOGNIZED COMMAND");
                    return null;
            }
            switch (tokens[1])
            {
                case "game":
                    cb.SetModelGame();
                    break;
                case "rat":
                    cb.SetModelRat();
                    break;
                default:
                    Console.WriteLine("ERROR: UNRECOGNIZED COMMAND");
                    return null;
            }
            cb.SetArg0(tokens[2]);

            cmd = cb.BuildCommand();

            return cmd;
        }
    }
}