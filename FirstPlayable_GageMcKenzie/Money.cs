using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Money
    {
        public int gold;
        Position _moneyPos;
        Player _player;
       List <bool> PickedUp = new List<bool>() {false,false,false };

        public Money(int Value,Player player) 
        { 
            gold = Value;
            _player = player;
        }
        public void drawMoney()
        {
            PlaceMoney(new List<int>() { 5, 10, 1 }, new List<int>() { 8, 7, 4 });
        }

        public void PlaceMoney(List <int> xPos, List<int> yPos)
        {
            for (int i = 0; i < xPos.Count; i++)
            {
                if (PickedUp[i] == false)
                {
                    _moneyPos.x = xPos[i];
                    _moneyPos.y = yPos[i];
                    Console.SetCursorPosition(_moneyPos.x, _moneyPos.y);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write('+');
                    Console.ForegroundColor = ConsoleColor.Black;

                    if (_player._currentPos.x == _moneyPos.x && _player._currentPos.y == _moneyPos.y)
                    {
                        _player.money += gold;
                        PickedUp[i] = true;
                    }
                }
            }
            
        }
        
    }
}
