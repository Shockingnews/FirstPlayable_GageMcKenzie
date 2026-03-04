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
        protected List<bool> PickedUp = new List<bool>();
        char _itemLogo;
        ConsoleColor _itemColor;

        public Items( Player player, List<int> posX, List<int> posY, int numberOfItems, char itemLogo, ConsoleColor itemColor)
        {
            for(int i = 0; i < numberOfItems; i++)
            {
                PickedUp.Add(false);
            }
            _itemLogo = itemLogo;
            _itemColor = itemColor;
            _posX = posX;
            _posY = posY;
            
            _player = player;
        }
        

        public virtual void PlaceItem()
        {
            for (int i = 0; i < PickedUp.Count; i++)
            {
                //d
                if (PickedUp[i] != true)
                {

                    _itemPos.x = _posX[i];
                    _itemPos.y = _posY[i];
                    Console.SetCursorPosition(_itemPos.x, _itemPos.y);
                    Console.ForegroundColor = _itemColor;
                    Console.Write(_itemLogo);
                    Console.ForegroundColor = ConsoleColor.Black;


                    if (_player.currentPos.x == _itemPos.x && _player.currentPos.y == _itemPos.y)
                    {
                        
                        PickedUp[i] = true;
                        //PickedUp.Remove(PickedUp[i]);
                        _player.PreviousPos();
                    }
                }
            }

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
