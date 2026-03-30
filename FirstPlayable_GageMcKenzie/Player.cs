using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Player : Character
    {
        
        HealthSystem _currentShield;
        HealthSystem _currentHealth;
        public string _name;
        public Position currentPos = new Position();
        public Position previousPos = new Position();
        bool _alive = true;
        ConsoleKeyInfo _playerInput;
        public int money;
        int _damage;



        public Player(int maxHealth, int maxShield, string name, int gold, int currentPosX, int currentPosY, bool isAlive, int damage) : base(health: maxHealth, shield: maxShield)
        {
            _damage = damage;
            _alive = isAlive;
            _currentHealth = new HealthSystem(Health: maxHealth);
            _currentShield = new HealthSystem(Health: maxShield);
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
            previousPos.x = currentPos.x;
            previousPos.y = currentPos.y;
            UpdatePreviousPos();
            //if (_playerInput.Key == ConsoleKey.W)
            //{
            //    currentPos.y -= 1;
            //    previousPos.y = currentPos.y + 1;
            //}
            //else if (_playerInput.Key == ConsoleKey.S)
            //{
            //    currentPos.y += 1;
            //    previousPos.y = currentPos.y - 1;
            //}
            //else if (_playerInput.Key == ConsoleKey.A)
            //{
            //    currentPos.x -= 1;
            //    previousPos.x = currentPos.x + 1;
            //}
            //else if (_playerInput.Key == ConsoleKey.D)
            //{
            //    currentPos.x += 1;
            //    previousPos.x = currentPos.x - 1;
            //}

        }

        void UpdatePreviousPos()
        {
            if (_playerInput.Key == ConsoleKey.W)
            {
                previousPos.y += 1;
                

            }
            else if (_playerInput.Key == ConsoleKey.S)
            {
                previousPos.y -= 1;
                
            }
            else if (_playerInput.Key == ConsoleKey.A)
            {
                previousPos.x += 1;
                
            }
            else if (_playerInput.Key == ConsoleKey.D)
            {
                previousPos.x -= 1;
                
            }
        }

        public void PreviousPos()
        {
            currentPos.y = previousPos.y;
            currentPos.x = previousPos.x;

            //if (_playerInput.Key == ConsoleKey.W)
            //{
            //    previousPos.y += 1;
            //    currentPos.y = previousPos.y;

            //}
            //else if (_playerInput.Key == ConsoleKey.S)
            //{
            //    previousPos.y -= 1;
            //    currentPos.y = previousPos.y;
            //}
            //else if (_playerInput.Key == ConsoleKey.A)
            //{
            //    previousPos.x += 1;
            //    currentPos.x = previousPos.x;
            //}
            //else if (_playerInput.Key == ConsoleKey.D)
            //{
            //    previousPos.x -= 1;
            //    currentPos.x = previousPos.x;
            //}
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

        public override void TakeDamage(int chooseDamage) 
        {
            base.TakeDamage(chooseDamage: chooseDamage);
            
        }
        public int Damage()
        {
            return _damage;
        }

        public void AddDamage(int addDamage)
        {
            _damage += addDamage;
        }

        public bool IsALive()
        {
            if(base.maxHealth.health <= 0)
            {
                _alive = false;
                base.maxHealth.health = 0;
                return false;
                
            }
            return true;
        }

        public void PlayerHud()
        {
            Console.SetCursorPosition(0, 39);
            Console.WriteLine($"Player Name: {_name} Health: {base.maxHealth.health} Shield: {base.maxShield.health}  Gold: {money}");
        }
        
        
    }
}
