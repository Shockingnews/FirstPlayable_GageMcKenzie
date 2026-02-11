using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstPlayable_GageMcKenzie
{
    internal class Program
    {
        static Map map = new Map(player, enemy);
        public static bool alive = true;
        
        
        static Player player = new Player(100, 50, "Gage", 0, 0, 0);
        static Enemy enemy = new Enemy(5, "gabe", 5, 5, 5, player);
        static void Main(string[] args)
        {
            Playing();

        }
        static void Playing()
        {
            while (alive == true)
            {
                Update();
                
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        static void Draw()
        {
            map.PrintMap();
        }

        static void Update()
        {
            player.UpdatePlayer();
            if(player._currentPos.x == enemy._enemyPos.x && player._currentPos.y == enemy._enemyPos.y)
            {
                player.TakeDamage();
                player.PreviousPos();
            }
            enemy.UpdateEnemy();
            if (player._currentPos.x == enemy._enemyPos.x && player._currentPos.y == enemy._enemyPos.y)
            {
                enemy.TakeDamage();
                enemy.PrePos();
            }
            player.IsALive();
            Draw();

        }
    }
}
