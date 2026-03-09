using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class IncreaseDamageItem : Items
    {
        int _numOfShieldItems;
        int _damageIncrease;
        Player _player;
        public IncreaseDamageItem(Player player, int xPos, int yPos, int numOfShields, char shieldLogo, ConsoleColor shieldColor, int damageIncrease) : base(player: player, posX: xPos, posY: yPos, numberOfItems: numOfShields, itemLogo: shieldLogo, itemColor: shieldColor)
        {
            _numOfShieldItems = numOfShields;
            _player = player;
            _damageIncrease = damageIncrease;
        }

        public override void PlaceItem()
        {
            base.PlaceItem();
            
                if (base.PickedUp == true)
                {
                    _player.AddDamage(_damageIncrease);
                    
                }
            
            

        }
    }
}
