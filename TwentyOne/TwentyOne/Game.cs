using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        public abstract void Play(); // abstract method has no implementation but inheriting class must override and define it
        public virtual void ListPlayer() // virtual method has implementation but can be overridden or added to in inherting class.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
