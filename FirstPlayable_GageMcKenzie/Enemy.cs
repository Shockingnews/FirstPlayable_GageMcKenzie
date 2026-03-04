using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Enemy : Character
    {
        
        
        public string _name;
        
        public Position _enemyPos;
        Player _player;
        public bool _alive = true;
        int _randomMovement;
        int _damage;
        char _enemyLogo;
        ConsoleColor _color;


        public Enemy(int maxHealth, int maxShield, string name, int enemyPosX, int enemyPosY, Player player, int damage, bool isAlive, char enemyLogo, ConsoleColor color) : base(health: maxHealth, shield: maxShield)
        {
            _color = color;
            _enemyLogo = enemyLogo;
            _alive = isAlive;
            _name = name;
            _damage = damage;
            _name = name;
            
            _player =  player;
            _enemyPos.x = enemyPosX;
            _enemyPos.y = enemyPosY;

        }

        public virtual void Move()
        {
            if (base.maxHealth.health != 0)
            {
                if (_enemyPos.x <= _player.currentPos.x + 3 && _enemyPos.x >= _player.currentPos.x - 3 || _enemyPos.x <= _player.currentPos.y + 3 && _enemyPos.x >= _player.currentPos.y - 3)
                {
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
            
            
        }

        public virtual void UpdateEnemy()
        {
            if (_alive == true)
            {
                Move();
                
                DrawEnemy();
                if(base.maxHealth.health <= 0)
                {
                    _alive = false;
                }
            }
            
        }

        public virtual void DrawEnemy()
        {
            Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
            Console.ForegroundColor = _color;
            Console.Write(_enemyLogo);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual void PrePos()
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
                    _enemyPos.y += 1;

                }
                else if (_enemyPos.y < _player.currentPos.y)
                {
                    _enemyPos.y -= 1;

                }
            }
        }
        public virtual int Damage()
        {
            return _damage;
        }

        public override void TakeDamage(int chooseDamage)
        {
            
                base.TakeDamage(chooseDamage: chooseDamage);
            
        }
        public virtual bool IsAlive()
        {
            return _alive;
        }
        
    }
}
