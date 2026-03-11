using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Items
    {
        List<int> _posX;
        List<int> _posY;
        Position _itemPos;
        Player _player;
        protected bool PickedUp = false;
        char _itemLogo;
        ConsoleColor _itemColor;

        public Items( Player player, int posX, int posY, int numberOfItems, char itemLogo, ConsoleColor itemColor)
        {
            
            _itemLogo = itemLogo;
            _itemColor = itemColor;
            _itemPos.x = posX;
            _itemPos.y = posY;
            
            _player = player;
        }
        

        public virtual void PlaceItem()
        {
            
                //d
                if (PickedUp != true)
                {

                    
                    Console.SetCursorPosition(_itemPos.x, _itemPos.y);
                    Console.ForegroundColor = _itemColor;
                    Console.Write(_itemLogo);
                    Console.ForegroundColor = ConsoleColor.Black;


                    if (_player.currentPos.x == _itemPos.x && _player.currentPos.y == _itemPos.y)
                    {
                        OnPickUp();
                        
                        //if (PickedUp[i] = true)
                        //{
                        //    PickedUp.Remove(PickedUp[i]);
                        //}
                    }
                }
            

        }

        public virtual void OnPickUp()
        {
            PickedUp = true;

            
        }

        //public void Draw()
        //{
        //    _itemPos.x = _posX[i];
        //    _itemPos.y = _posY[i];
        //    Console.SetCursorPosition(_itemPos.x, _itemPos.y);
        //    Console.ForegroundColor = _itemColor;
        //    Console.Write('k');
        //}
    }
}
