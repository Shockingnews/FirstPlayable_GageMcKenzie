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
        bool PickedUp = false;

        public Money(int Value,Player player) 
        { 
            gold = Value;
            _player = player;
        }
        public void drawMoney()
        {
            CheckPlayerPos(_player._currentPos);
        }

        public void PlaceMoney(int xPos,int yPos)
        {
            
            
            
                _moneyPos.x = xPos;
                _moneyPos.y = yPos;
                Console.SetCursorPosition(_moneyPos.x, _moneyPos.y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write('+');
                Console.ForegroundColor = ConsoleColor.Black;
            
        }
        public void CheckPlayerPos(Position playerPos)
        {
            if (PickedUp == false)
            {
                PlaceMoney(5, 10);
                if (playerPos.x == _moneyPos.x && playerPos.y == _moneyPos.y)
                {
                    _player.money += gold;
                    PickedUp = true;
                }
            }
        }
    }
}
