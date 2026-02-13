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
        static Enemy enemy = new Enemy(5, "gabe", 5, 10, 20, player);

        static Money gold = new Money(1, player);

        static Map map = new Map(player, enemy);
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
            enemy.DrawEnemy();

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
            
            player.IsALive();
            turns -= 0;
            Console.Clear();
            
            
        }
    }
}
