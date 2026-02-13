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
        public string _name;
        public Position currentPos = new Position();
        bool _alive = true;
        ConsoleKeyInfo _playerInput;
        public int money;



        public Player(int maxHealth, int maxShield, string name, int gold, int currentPosX, int currentPosY, bool isAlive) : base(health: maxHealth)
        {
            _alive = isAlive;
            _maxShield = new HealthSystem(Health: maxShield);
            _maxHealth = new HealthSystem(Health: maxHealth);
            _currentHealth = _maxHealth;
            _currentShield = _maxShield;
            _name = name;
            currentPos.x = currentPosX;
            currentPos.y = currentPosY;
            money = gold;

        }

        public void Move()
        {
            _playerInput = Console.ReadKey(true);
            if(_playerInput.Key == ConsoleKey.W)
            {
                currentPos.y -= 1;
            }
            else if (_playerInput.Key == ConsoleKey.S)
            {
                currentPos.y += 1;
            }
            else if (_playerInput.Key == ConsoleKey.A)
            {
                currentPos.x -= 1;
            }
            else if (_playerInput.Key == ConsoleKey.D)
            {
                currentPos.x += 1;
            }
            
        }

        public void PreviousPos()
        {
            if (_playerInput.Key == ConsoleKey.W)
            {
                currentPos.y += 1;
            }
            else if (_playerInput.Key == ConsoleKey.S)
            {
                currentPos.y -= 1;
            }
            else if (_playerInput.Key == ConsoleKey.A)
            {
                currentPos.x += 1;
            }
            else if (_playerInput.Key == ConsoleKey.D)
            {
                currentPos.x -= 1;
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
            
            Console.SetCursorPosition(currentPos.x, currentPos.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('0');
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void TakeDamage(int chooseDamage) 
        {
            _currentHealth.TakeDamage(chooseDamage);
            
        }
        public bool IsALive()
        {
            if(_currentHealth.health <= 0)
            {
                _alive = false;
                _currentHealth.health = 0;
                return false;
                
            }
            return true;
        }

        public void PlayerHud()
        {
            Console.WriteLine($"Player Name: {_name} Health: {_currentHealth.health} Sheild: {_currentShield.health}  Gold: {money}");
        }
        
        
    }
}
