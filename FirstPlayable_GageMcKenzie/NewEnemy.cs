using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FirstPlayable_GageMcKenzie
{
    internal class NewEnemy : Enemy
    {

        int _damage;
        string _name;
        int _gold;
        public Position _enemyPos;
        Player _player;
        static bool _alive = true;
        

        public NewEnemy(int maxHealth, int maxShield, string name, int gold, int enemyPosX, int enemyPosY, Player player, int damage) : base( maxHealth: maxHealth, maxShield: maxShield, name: name, gold: gold,enemyPosX: enemyPosX, enemyPosY: enemyPosY, player: player, damage: damage, isAlive: _alive)
        {
            //_damage = damage;
            //_name = name;
            //_gold = gold;
            _player = player;
            _enemyPos.x = enemyPosX;
            _enemyPos.y = enemyPosY;

        }

        public override void Move()
        {
            if (base.maxHealth.health != 0)
            {
                if(_player.currentPos.x >= _enemyPos.x + 3 || _player.currentPos.x >= _enemyPos.x - 3)
                {
                    if (_player.currentPos.y >= _enemyPos.y + 3 || _player.currentPos.y >= _enemyPos.y - 3)
                    {
                       
                            if (_enemyPos.x > _player.currentPos.x)
                            {
                                _enemyPos.x -= 1;

                            }
                            else if (_enemyPos.x < _player.currentPos.x)
                            {
                                _enemyPos.x += 1;

                            }
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

        public override void UpdateEnemy()
        {
            base.UpdateEnemy();
            //if (_alive == true)
            //{
            //    Move();
            //    TakeDamage(10);
            //    DrawEnemy();
            //}
            //else return;
        }

        public override void DrawEnemy()
        {
            Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write('I');
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void PrePos()
        {
            

            
                if (_enemyPos.x > _player.currentPos.x)
                {
                    _enemyPos.x += 1;

                }
                else if (_enemyPos.x < _player.currentPos.x)
                {
                    _enemyPos.x -= 1;

                }
            
            
                if (_enemyPos.y > _player.currentPos.y)
                {
                    _enemyPos.y += 1;

                }
                else if (_enemyPos.y < _player.currentPos.y)
                {
                    _enemyPos.y -= 1;

                }
            
        }


        public override int Damage()
        {
           return base.Damage();
        }

        //public override void TakeDamage(int chooseDamage)
        //{

        //    base.TakeDamage(chooseDamage: chooseDamage);

        //}
        public override bool IsAlive()
        {
            return base.IsAlive();
        }
    }
}
