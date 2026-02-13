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
        
        public static bool alive = true;
        
        
        static Player player = new Player(100, 50, "Gage", 0, 0, 0);
        static Enemy enemy = new Enemy(5, "gabe", 5, 5, 5, player);

        static Map map = new Map(player, enemy);
        static void Main(string[] args)
        {
            Playing();

        }
        static void Playing()
        {
            while (alive == true)
            {
                Update();
                
                
            }
        }

        static void Draw()
        {
            Console.SetCursorPosition(0, 0);
            map.PrintMap();
        }

        static void Update()
        {
            Draw();

            player.UpdatePlayer();
            if(player._currentPos.x == enemy._enemyPos.x && player._currentPos.y == enemy._enemyPos.y)
            {
                player.TakeDamage();
                player.PreviousPos();
            }
            map.CheckPos();
            enemy.UpdateEnemy();
            if (player._currentPos.x == enemy._enemyPos.x && player._currentPos.y == enemy._enemyPos.y)
            {
                enemy.TakeDamage();
                enemy.PrePos();
            }
            map.CheckPos();
            player.IsALive();

            
        }
    }
}
