using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirstPlayable_GageMcKenzie
{
    internal class ChunkyEnemy : Enemy
    {
        public Position _enemyPos;
        Player _player;
        int _randomMovement;
        static bool _alive = true;
        public ChunkyEnemy(int maxHealth, int maxShield, string name, int gold, int enemyPosX, int enemyPosY, Player player, int damage) : base(maxHealth: maxHealth, maxShield: maxShield, name: name, gold: gold, enemyPosX: enemyPosX, enemyPosY: enemyPosY, player: player, damage: damage, isAlive:_alive)
        {
            _player = player;
            _enemyPos.x = enemyPosX;
            _enemyPos.y = enemyPosY;
        }

        public override void Move()
        {
            if (base.maxHealth.health != 0)
            {
                if (_player.currentPos.x >= _enemyPos.x + 3 || _player.currentPos.x >= _enemyPos.x - 3)
                {
                    if (_player.currentPos.y >= _enemyPos.y + 3 || _player.currentPos.y >= _enemyPos.y - 3)
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


        }


        public override void DrawEnemy()
        {
            Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write('@');
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
