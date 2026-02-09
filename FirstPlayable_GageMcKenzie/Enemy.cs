using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Enemy : Character
    {
        HealthSystem _Health;
        string _name;
        int _gold;
        public Position _enemyPos;
        Position _playerPos;
        
        public Enemy(int health, string name, int gold, Position enemyPos, Position playerPos) 
        {
            _Health = new HealthSystem(health);
            _name = name;
            _gold = gold;
            _playerPos = new Position(playerPos.x, playerPos.y);
            _enemyPos = new Position(enemyPos.x, enemyPos.y);

        }

        public void Move()
        {
            Random random = new Random();
            int randomMovement = random.Next(1, 3);
            if(randomMovement == 1)
            {
                if (_enemyPos.x > _playerPos.x)
                {
                    _enemyPos.x -= 1;
                }
                else if (_enemyPos.x < _playerPos.x)
                {
                    _enemyPos.x += 1;
                }
            }
            if(randomMovement == 2)
            {
                if (_enemyPos.y > _playerPos.y)
                {
                    _enemyPos.y -= 1;
                }
                else if (_enemyPos.y > _playerPos.y)
                {
                    _enemyPos.y += 1;
                }
            }
            
            
        }

        public void UpdateEnemy()
        {
            Move();
            DrawEnemy();
        }

        void DrawEnemy()
        {
            Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(' ');
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void TakeDamage()
        {
            
        }
        
    }
}
