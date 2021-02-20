using System;
using System.Collections.ObjectModel;

namespace rr_cli
{
    public class Server
    {
        ObservableCollection<Rat> rats;
        ObservableCollection<Game> games;

        public Server()
        {
            this.rats = new ObservableCollection<Rat>();
            this.games = new ObservableCollection<Game>();
        }

        internal void ListRats()
        {
            foreach (Rat rat in this.rats)
            {
                Console.WriteLine($"{rat.name}");
            }
        }

        internal void ListGames()
        {
            foreach (Game game in this.games)
            {
                Console.WriteLine($"{game.name}");
            }
        }

        public void RunCommand(ClientCommand c)
        {
            c.Execute(this);
        }

        public void CreateRat(string name)
        {
            Rat rat = new Rat(name);
            this.rats.Add(rat);
            Console.WriteLine($"Added a rat named {name}");
        }

        public void CreateGame(
            string name,
            int buyinCost=10,
            int baseCost=10,
            RewardEnum rewardEnum=RewardEnum.EQUAL
            )
        {
            Reward reward = new EqualReward();
            Game game = new Game(name, buyinCost, baseCost, reward);
            this.games.Add(game);
            Console.WriteLine($"Added a game named {name}");
        }
    }
}