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
        Player _player;
        public IncreaseDamageItem(Player player, List<int> xPos, List<int> yPos, int numOfShields, char shieldLogo, ConsoleColor shieldColor) : base(player: player, posX: xPos, posY: yPos, numberOfItems: numOfShields, itemLogo: shieldLogo, itemColor: shieldColor)
        {
            _numOfShieldItems = numOfShields;
            _player = player;
        }

        public override void PlaceItem()
        {
            base.PlaceItem();
            for (int i = 0; i < _numOfShieldItems; i++)
            {
                if (base.PickedUp[i] == true)
                {
                     
                }
            }

        }
    }
}
