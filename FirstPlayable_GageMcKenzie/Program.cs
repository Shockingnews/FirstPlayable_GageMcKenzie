using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstPlayable_GageMcKenzie
{
    internal class Program
    {

        static Player player = new Player(100, 50, "Gage", 0, new Position(0, 0), enemy._enemyPos);
        static Enemy enemy = new Enemy(5, "gabe", 5, new Position(5, 5), player._currentPos);
        static void Main(string[] args)
        {
            
            


            player.UpdatePlayer();
            enemy.UpdateEnemy();
            player.UpdatePlayer();
            enemy.UpdateEnemy();
            player.UpdatePlayer();
            enemy.UpdateEnemy();

        }

    }
}
