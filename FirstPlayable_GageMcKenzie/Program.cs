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
        static bool alive = true;


        static Player player = new Player(100, 50, "Gage", 0, 5, 5, alive, 10);
        static List<Enemy> enemies = new List<Enemy>() 
        { 
            new Enemy(5,0, "Mason", 5, 11, 20, player,1),
            new NewEnemy(maxHealth: 5,maxShield:0,name: "jerry", gold: 0, enemyPosX: 25, enemyPosY: 24, player: player, damage: 1),
            new ChunkyEnemy(maxHealth: 5, maxShield: 0,name: "Terry", gold: 0, enemyPosX: 27, enemyPosY: 24, player: player, damage: 1)

        };

        static ChestItem chest = new ChestItem(enemies, player, 1, new List<int>() { 15}, new List<int>() { 15 }, '#', ConsoleColor.DarkGray);
        //static ShieldItem shieldItem = new ShieldItem(player, new List<int>(10), new List<int>(10), 1, '(', ConsoleColor.DarkCyan);
        
        static GameHud gameHud = new GameHud( player, enemies);
        static List<NewEnemy> newEnemies = new List<NewEnemy>()
        {
            //new NewEnemy(maxHealth: 5,maxShield:0,name: "jerry", gold: 0, enemyPosX: 25, enemyPosY: 24, player: player, damage: 1)
        };
        

        static Money gold = new Money(1, player);

        static Map map = new Map(player, enemies);
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Playing();

            Console.WriteLine("Game Over");

            Console.ReadKey(true);

            Console.Clear();

        }
        static void Playing()
        {
            Draw();
            while (turns != 0 && player.IsALive() == true)
            {
                Update();
                
                
                
            }
        }

        static void Draw()
        {
            Console.SetCursorPosition(0, 0);
            map.PrintMap();
            player.PlayerHud();
            
            
            chest.PlaceItem();
            
            
            gold.drawMoney();
            player.DrawPlayer();
            enemies[0].DrawEnemy();
            enemies[1].DrawEnemy();
            enemies[2].DrawEnemy();

            //newEnemies[0].DrawEnemy();
        }

        static void Update()
        {

            



            player.UpdatePlayer();
            for (int i = 0; i < enemies.Count(); i++)
            {
                if (player.currentPos.x == enemies[i]._enemyPos.x && player.currentPos.y == enemies[i]._enemyPos.y)
                {
                    player.TakeDamage(5);
                    player.PreviousPos();
                    
                }
                map.CheckPos();
                enemies[i].UpdateEnemy();
                
                if (player.currentPos.x == enemies[i]._enemyPos.x && player.currentPos.y == enemies[i]._enemyPos.y)
                {
                    enemies[i].TakeDamage(10);
                    enemies[i].PrePos();
                    player.PreviousPos();
                }
            }
            //newEnemies[0].UpdateEnemy();

            player.IsALive();
            turns -= 0;
            Console.Clear();
            Draw();


        }
    }
}
