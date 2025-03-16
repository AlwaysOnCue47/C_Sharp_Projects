using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
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
