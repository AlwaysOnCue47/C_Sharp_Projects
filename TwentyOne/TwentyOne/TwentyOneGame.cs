using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
        }

        public override void ListPlayer()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayer();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
