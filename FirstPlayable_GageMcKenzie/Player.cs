using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Player : Character
    {
        HealthSystem _health;
        HealthSystem _shield;
        string _name;
        Position _currentPos;
        Position _lastPos;
        public Player(HealthSystem health, HealthSystem shield, string name, int gold, Position currentPos)
        {
            _shield = shield;
            _health = health;
            _name = name;
            _currentPos = currentPos;
            _lastPos = currentPos;

        }

        public void Position()
        {
            Console.Write(_currentPos.x);
            Console.Write(_currentPos.y);
        }

        public void Move()
        {
            ConsoleKeyInfo playerInput = Console.ReadKey(true);
            if(playerInput.Key == ConsoleKey.W)
            {
                _currentPos.y += 1;
            }
            else if (playerInput.Key == ConsoleKey.S)
            {
                _currentPos.y -= 1;
            }
            else if (playerInput.Key == ConsoleKey.A)
            {
                _currentPos.x -= 1;
            }
            else if (playerInput.Key == ConsoleKey.D)
            {
                _currentPos.x += 1;
            }
        }
        


    }
}
