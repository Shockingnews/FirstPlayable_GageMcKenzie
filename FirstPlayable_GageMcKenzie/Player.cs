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
        public Position _currentPos = new Position();
        Position _lastPos;
        bool _alive = true;

        
        public Player(int health, int shield, string name, int gold, int currentPosX, int currentPosY) : base(health, name, currentPosY, currentPosX)
        {
            
            _shield = new HealthSystem(shield);
            _health = new HealthSystem(health);
            _name = name;
            _currentPos.x = currentPosX;
            _currentPos.y = currentPosY;
            _lastPos = _currentPos;

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

        public void PreviousPos()
        {
            _currentPos = _lastPos;
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

        public void TakeDamage()
        {
            
                _health._health -= 5;
                _currentPos = _lastPos;
            
            
        }
        public void IsALive()
        {
            if(_health._health == 0)
            {
                _alive = false;
                
            }
        }
        
        
    }
}
