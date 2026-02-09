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
        public Player(int health, int shield, string name, int gold, Position currentPos)
        {
            _shield = new HealthSystem(shield);
            _health = new HealthSystem(health);
            _name = name;
            _currentPos = currentPos;
            _lastPos = currentPos;

        }

        public void Move()
        {
            ConsoleKeyInfo playerInput = Console.ReadKey(true);
            if(playerInput.Key == ConsoleKey.W)
            {
                _currentPos.y -= 1;
            }
            else if (playerInput.Key == ConsoleKey.S)
            {
                _currentPos.y += 1;
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

        public void UpdatePlayer()
        {
            Move();
            DrawPlayer();
            
        }
        public void DrawPlayer()
        {
            
            Console.SetCursorPosition(_currentPos.x, _currentPos.y);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(' ');
            Console.BackgroundColor = ConsoleColor.Black;

        }
        
    }
}
