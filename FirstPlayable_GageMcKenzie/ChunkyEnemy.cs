using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class ChunkyEnemy : Enemy
    {
        Player _player;
        int _randomMovement;



        public ChunkyEnemy(int maxHealth, int maxShield, string name, int enemyPosX, int enemyPosY, Player player, int damage, bool isAlive, char enemyLogo, ConsoleColor color) : base(maxHealth: maxHealth, maxShield: maxShield, name: name, enemyPosX: enemyPosX, enemyPosY: enemyPosY, player: player, damage: damage, isAlive: isAlive, enemyLogo: enemyLogo, color: color)
        {
            _player = player;
        }

        public override void Move()
        {
            if (base.maxHealth.health != 0)
            {

                if (base._enemyPos.x <= _player.currentPos.x + 3 && base._enemyPos.x >= _player.currentPos.x - 3 || base._enemyPos.x <= _player.currentPos.y + 3 && base._enemyPos.x >= _player.currentPos.y - 3)
                {

                    Random random = new Random();
                    _randomMovement = random.Next(1, 3);
                    if (_randomMovement == 1)
                    {
                        if (base._enemyPos.x > _player.currentPos.x)
                        {
                            base._enemyPos.x -= 1;

                        }
                        else if (base._enemyPos.x < _player.currentPos.x)
                        {
                            base._enemyPos.x += 1;

                        }
                    }

                    if (_randomMovement == 2)
                    {
                        if (base._enemyPos.y > _player.currentPos.y)
                        {
                            base._enemyPos.y -= 1;

                        }
                        else if (base._enemyPos.y < _player.currentPos.y)
                        {
                            base._enemyPos.y += 1;

                        }
                    }

                }

            }


        }
        public override void Reset()
        {
            base.Reset();
        }
        public override void UpdateEnemy()
        {
            if (base._alive == true)
            {
                Move();

                DrawEnemy();
                if (base.maxHealth.health <= 0)
                {
                    base._alive = false;
                }
            }

        }

        public override void DrawEnemy()
        {
            base.DrawEnemy();
            //Console.SetCursorPosition(base._enemyPos.x, base._enemyPos.y);
            //Console.ForegroundColor = _color;
            //Console.Write(_enemyLogo);
            //Console.ForegroundColor = ConsoleColor.White;
        }

        public override void PrePos()
        {
            if (_randomMovement == 1)
            {
                if (base._enemyPos.x > _player.currentPos.x)
                {
                    base._enemyPos.x += 1;

                }

                else if (base._enemyPos.x < _player.currentPos.x)
                {
                    base._enemyPos.x -= 1;

                }
            }

            if (_randomMovement == 2)
            {
                if (base._enemyPos.y > _player.currentPos.y)
                {
                    base._enemyPos.y += 1;

                }
                else if (base._enemyPos.y < _player.currentPos.y)
                {
                    base._enemyPos.y -= 1;

                }
            }

        }
        public override int Damage()
        {
            return base.Damage();
        }

        public override void TakeDamage(int chooseDamage)
        {

            base.TakeDamage(chooseDamage: chooseDamage);

        }
        public override bool IsAlive()
        {
            return base._alive;
        }
    }
}
