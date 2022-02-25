using System.Collections.Generic;
using domain.common;

namespace domain.player
{
    public class Player : Character
    {
        public Player()
        {
            Name = "Zeca";
            Description = "Jogador";
            Inventory = new List<Item>();
        }
    }
}
