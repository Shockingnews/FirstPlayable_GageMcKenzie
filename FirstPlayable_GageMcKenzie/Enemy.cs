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
        int _randomMovement;
        
        public Enemy(int health, string name, int gold, int enemyPosX, int enemyPosY, Player player) : base(health)
        {
            _Health = new HealthSystem(Health: health);
            _name = name;
            _gold = gold;
            _player =  player;
            _enemyPos.x = enemyPosX;
            _enemyPos.y = enemyPosY;

        }

        public void Move()
        {
            if (_Health.health != 0)
            {
                _enemyPrePos = _enemyPos;
                Random random = new Random();
                 _randomMovement = random.Next(1, 3);
                if (_randomMovement == 1)
                {
                    if (_enemyPos.x > _player.currentPos.x)
                    {
                        _enemyPos.x -= 1;
                        
                    }
                    else if (_enemyPos.x < _player.currentPos.x)
                    {
                        _enemyPos.x += 1;
                        
                    }
                }
                if (_randomMovement == 2)
                {
                    if (_enemyPos.y > _player.currentPos.y)
                    {
                        _enemyPos.y -= 1;
                        
                    }
                    else if (_enemyPos.y < _player.currentPos.y)
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
                TakeDamage(10);
                DrawEnemy();
            }
            else return;
        }

        public void DrawEnemy()
        {
            Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('x');
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrePos()
        {
            if (_randomMovement == 1)
            {
                if (_enemyPos.x > _player.currentPos.x)
                {
                    _enemyPos.x += 1;
                }
                else if (_enemyPos.x < _player.currentPos.x)
                {
                    _enemyPos.x -= 1;
                }
            }
            if (_randomMovement == 2)
            {
                if (_enemyPos.y > _player.currentPos.y)
                {
                    _enemyPos.y = 1;
                }
                else if (_enemyPos.y < _player.currentPos.y)
                {
                    _enemyPos.y = 1;
                }
            }
        }

        public void TakeDamage( int chooseDamage)
        {
            if(_player.currentPos.x == _enemyPos.x && _player.currentPos.y == _enemyPos.y)
            {
                _Health.TakeDamage(chooseDamage);
            }
        }
        
    }
}
