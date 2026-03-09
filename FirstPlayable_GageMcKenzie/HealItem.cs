using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class HealItem : Items
    {
        int _numOfHeals;
        Player _player;
        public HealItem(Player player, int xPos, int yPos, int numOfHeals, char healLogo, ConsoleColor healColor) : base(player: player, posX: xPos, posY: yPos, numberOfItems: numOfHeals, itemLogo: healLogo,  itemColor: healColor)
        {
            _numOfHeals = numOfHeals;
            _player = player;
        }
        public override void PlaceItem()
        {
            base.PlaceItem();
            
                
            
            
        }

        public override void OnPickUp()
        {
            base.OnPickUp();
            _player.maxHealth.health += 1;
        }
    }
}
