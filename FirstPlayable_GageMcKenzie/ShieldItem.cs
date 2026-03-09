using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    
    internal class ShieldItem : Items
    {
        int _numOfShieldItems;
        Player _player;
        public ShieldItem(Player player, int xPos, int yPos, int numOfShields, char shieldLogo, ConsoleColor shieldColor) : base(player: player, posX: xPos, posY: yPos, numberOfItems: numOfShields, itemLogo: shieldLogo, itemColor: shieldColor)
        {
            _numOfShieldItems = numOfShields;
            _player = player;
        }

        public override void PlaceItem()
        {
            
            base.PlaceItem();
            
            
                if (base.PickedUp == true)
                {
                    
                        _player.maxShield.health += 1;
                    



                }
            
            

        }
    }

}
