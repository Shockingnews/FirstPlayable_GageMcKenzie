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
        
        public static int turns = 50;

        
        
        static Player player = new Player(100, 50, "Gage", 0, 5, 5);
        static List<Enemy> enemies = new List<Enemy>() 
        { 
            new Enemy(5, "Mason", 5, 11, 20, player),
            new Enemy(5, "Gabe", 5, 15, 21, player),

        };
        

        static Money gold = new Money(1, player);

        static Map map = new Map(player, enemies);
        static void Main(string[] args)
        {
            Playing();

        }
        static void Playing()
        {
            while (turns != 0)
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
            player.PlayerHud();
            gold.drawMoney();
            player.DrawPlayer();
            enemies[0].DrawEnemy();
            enemies[1].DrawEnemy();

            player.UpdatePlayer();
            for (int i = 0; i < enemies.Count; i++)
            {
                if (player._currentPos.x == enemies[i]._enemyPos.x && player._currentPos.y == enemies[i]._enemyPos.y)
                {
                    player.TakeDamage();
                    player.PreviousPos();
                    
                }
                map.CheckPos();
                enemies[i].UpdateEnemy();
                if (player._currentPos.x == enemies[i]._enemyPos.x && player._currentPos.y == enemies[i]._enemyPos.y)
                {
                    enemies[i].TakeDamage();
                    enemies[i].PrePos();
                    player.PreviousPos();
                }
            }
            
            player.IsALive();
            turns -= 0;
            Console.Clear();
            
            
        }
    }
}
