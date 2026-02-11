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
        Position _enemyPrePos;
        Player _player;
        bool _alive = true;
        
        public Enemy(int health, string name, int gold, int enemyPosX, int enemyPosY, Player player) : base(health, name, enemyPosY, enemyPosX)
        {
            _Health = new HealthSystem(health);
            _name = name;
            _gold = gold;
            _player =  player;
            _enemyPos.x = enemyPosX;
            _enemyPos.y = enemyPosY;

        }

        public void Move()
        {
            if (_health._health != 0)
            {
                _enemyPrePos = _enemyPos;
                Random random = new Random();
                int randomMovement = random.Next(1, 3);
                if (randomMovement == 1)
                {
                    if (_enemyPos.x > _player._currentPos.x)
                    {
                        _enemyPos.x -= 1;
                    }
                    else if (_enemyPos.x < _player._currentPos.x)
                    {
                        _enemyPos.x += 1;
                    }
                }
                if (randomMovement == 2)
                {
                    if (_enemyPos.y > _player._currentPos.y)
                    {
                        _enemyPos.y -= 1;
                    }
                    else if (_enemyPos.y < _player._currentPos.y)
                    {
                        _enemyPos.y += 1;
                    }
                }
            }
            
            
        }

        public void UpdateEnemy()
        {
            if (_alive == true)
            {
                Move();
                TakeDamage();
                DrawEnemy();
            }
            else return;
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
            if(_player._currentPos.x == _enemyPos.x && _player._currentPos.y == _enemyPos.y)
            {
                _Health._health -= 10;
                _player.PreviousPos();
                _enemyPos = _enemyPrePos;
            }
        }
        
    }
}
