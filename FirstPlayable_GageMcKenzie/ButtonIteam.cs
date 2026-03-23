using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class ButtonItem : Items
    {
        Borders _borders;
        public ButtonItem(Player player, int xPos, int yPos, int numOfButtons, char buttonLogo, ConsoleColor buttonColor, Borders borders) : base(player: player, posX: xPos, posY: yPos, numberOfItems: numOfButtons, itemLogo: buttonLogo, itemColor: buttonColor)
        {
            _borders = borders;
        }
        public override void PlaceItem()
        {
            base.PlaceItem();




        }

        public override void OnPickUp()
        {
            base.OnPickUp();
            _borders.borders.Remove((20, 20));
        }
    }
}
