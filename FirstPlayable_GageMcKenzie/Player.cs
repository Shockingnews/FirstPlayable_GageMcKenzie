using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Player : Character
    {
        HealthSystem _maxHealth;
        HealthSystem _maxShield;
        HealthSystem _currentShield;
        HealthSystem _currentHealth;
        string _name;
        public Position _currentPos = new Position();
        bool _alive = true;
        ConsoleKeyInfo _playerInput;
        public int money;



        public Player(int maxHealth, int maxShield, string name, int gold, int currentPosX, int currentPosY) : base(maxHealth, name, currentPosY, currentPosX)
        {
            
            _maxShield = new HealthSystem(maxShield);
            _maxHealth = new HealthSystem(maxHealth);
            _currentHealth = _maxHealth;
            _currentShield = _maxShield;
            _name = name;
            _currentPos.x = currentPosX;
            _currentPos.y = currentPosY;
            money = gold;

        }

        public void Move()
        {
            _playerInput = Console.ReadKey(true);
            if(_playerInput.Key == ConsoleKey.W)
            {
                _currentPos.y -= 1;
            }
            else if (_playerInput.Key == ConsoleKey.S)
            {
                _currentPos.y += 1;
            }
            else if (_playerInput.Key == ConsoleKey.A)
            {
                _currentPos.x -= 1;
            }
            else if (_playerInput.Key == ConsoleKey.D)
            {
                _currentPos.x += 1;
            }
            
        }

        public void PreviousPos()
        {
            if (_playerInput.Key == ConsoleKey.W)
            {
                _currentPos.y += 1;
            }
            else if (_playerInput.Key == ConsoleKey.S)
            {
                _currentPos.y -= 1;
            }
            else if (_playerInput.Key == ConsoleKey.A)
            {
                _currentPos.x += 1;
            }
            else if (_playerInput.Key == ConsoleKey.D)
            {
                _currentPos.x -= 1;
            }
        }

        public void UpdatePlayer()
        {
            Move();
            DrawPlayer();
            IsALive();
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
                _currentHealth._health -= 5;
        }
        public void IsALive()
        {
            if(_currentHealth._health == 0)
            {
                _alive = false;
                
            }
        }

        public void PlayerHud()
        {
            Console.WriteLine($"Player Name: Gage Health: {_currentHealth._health} Sheild: {_currentShield._health}  Gold: {money}");
        }
        
        
    }
}
