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
        Position _enemyPos;
        Position _playerPos;
        
        public Enemy(int health, string name, int gold, Position enemyPos, Position playerPos) 
        {
            _Health = new HealthSystem(health);
            _name = name;
            _gold = gold;
            _playerPos = new Position(playerPos.x, playerPos.y);
            _enemyPos = new Position(enemyPos.x, enemyPos.y);

        }
        
    }
}
