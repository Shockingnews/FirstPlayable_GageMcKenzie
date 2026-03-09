using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class ChestItem : Items
    {
        List<Enemy> _enemies;
        public int _turns = 100;
        public ChestItem(List<Enemy> enemies, Player player, int numberOfChests, int xPos, int yPos, char ChestLogo, ConsoleColor ChestColor) : base(player: player, posX: xPos, posY: yPos, numberOfItems: numberOfChests, itemLogo: ChestLogo, itemColor: ChestColor)
        {
            _enemies = enemies;
        }

        public override void PlaceItem()
        {
            base.PlaceItem();
            
            if (base.PickedUp == true)
            {
                

                for(int i = 0; i < _enemies.Count(); i++)
                {
                    _enemies[i]._alive = false;
                }
            }
            

        }
        
    }
}
