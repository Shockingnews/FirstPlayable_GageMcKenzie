using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstPlayable_GageMcKenzie
{
    internal class GameHud
    {
        Player _player;
        List<Enemy> _enemies;
        public GameHud(Player player, List<Enemy> enemies)
        {
            _enemies = enemies;
            _player = player;
        }
        public void PlayerHud()
        {
            Console.WriteLine($"Player Name: {_player._name} Health: {_player.maxHealth.health} Shield: {_player.maxShield.health}  Gold: {_player.money}");
        }

        public void EnemyHud()
        {
            for(int i = 0; i < _enemies.Count(); i++)
            {
                if (_enemies[i]._enemyPos.x == _player.currentPos.x + 2)
                {
                    Console.WriteLine($"Player Name: {_enemies} Health: {_enemies[i].maxHealth.health} Shield: {_enemies[i].maxShield.health}  Gold: {_enemies}");
                }
            }
            
        }
    }
}
