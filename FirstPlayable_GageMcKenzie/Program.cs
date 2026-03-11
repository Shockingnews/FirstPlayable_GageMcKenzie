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


        static Player player = new Player(100, 50, "Gage", 0, 5, 5, alive, 5);
        static List<Enemy> enemies = new List<Enemy>() 
        {
            
            new ChunkyEnemy(maxHealth: 20, maxShield:0, name: "Heavy", enemyPosX: 10, enemyPosY: 24, player: player, damage: 10,isAlive: true, enemyLogo: '@', color: ConsoleColor.Red),
            new ChunkyEnemy(maxHealth: 20, maxShield:0, name: "Heavy", enemyPosX: 11, enemyPosY: 20, player: player, damage: 10,isAlive: true, enemyLogo: '@', color: ConsoleColor.Red),
            
            new SpeedyEnemy(maxHealth: 10, maxShield: 0, name: "Speedy Boi", enemyPosX: 30, enemyPosY: 5, player: player, damage: 5, isAlive: true, enemyLogo: 'I', color: ConsoleColor.Red),
            new SpeedyEnemy(maxHealth: 10, maxShield: 0, name: "Speedy Boi", enemyPosX: 30, enemyPosY: 15, player: player, damage: 5, isAlive: true, enemyLogo: 'I', color: ConsoleColor.Red)

        };

        static List<Items> items = new List<Items>()
        {
            new ChestItem(enemies, player, 1,16,  13 , '#', ConsoleColor.DarkGray),
            new ShieldItem(player, 15, 10, 2, '(', ConsoleColor.DarkCyan),
            new HealItem(player, 20, 10, 2, 'H', ConsoleColor.DarkGreen),

            
        };
        
        
        static GameHud gameHud = new GameHud( player, enemies);
        
        

        static Money gold = new Money(1, player);

        static Map map = new Map(player, enemies);
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            

            Playing();
            Console.Clear();
            if (player.IsALive() == false)
            {
                Console.WriteLine("Game Over");
            }
            else { Console.WriteLine("You Win"); }
            

            Console.ReadKey(true);

            Console.Clear();

        }
        static void Playing()
        {
            Draw();
            while (turns != 0 && player.IsALive() == true)
            {
                Update();
                for (int i = 0; i < enemies.Count(); i++)
                {
                    if (enemies[i]._alive == false)
                    {
                        
                        enemies.Remove(enemies[i]);
                    }
                    if(enemies.Count() == 0)
                    {
                       turns = 0;
                    }
                }



            }
        }

        static void Draw()
        {
            Console.SetCursorPosition(0, 0);
            map.PrintMap();

            
            gameHud.PlayerHud();
            gameHud.EnemyHud();

            for(int i = 0; i < items.Count(); i++)
            {
                items[i].PlaceItem();
            }
            
            
            gold.drawMoney();
            player.DrawPlayer();
            for (int i = 0; i < enemies.Count(); i++)
            {
                enemies[i].DrawEnemy();
            }
                
            

            
        }

        static void Update()
        {
            Draw();




            player.UpdatePlayer();
            for (int i = 0; i < enemies.Count(); i++)
            {
                if (player.currentPos.x == enemies[i]._enemyPos.x && player.currentPos.y == enemies[i]._enemyPos.y)
                {
                    player.TakeDamage(enemies[i].Damage());
                    player.PreviousPos();
                    
                }
                map.CheckPos();
                enemies[i].UpdateEnemy();
                
                if (player.currentPos.x == enemies[i]._enemyPos.x && player.currentPos.y == enemies[i]._enemyPos.y)
                {
                    enemies[i].TakeDamage(player.Damage());
                    enemies[i].PrePos();
                    
                }

                //if(enemies[i]._alive == false)
                //{
                //    enemies.Remove(enemies[i]);
                //}
            }
            

            player.IsALive();
            turns -= 0;
            Console.Clear();
            


        }
    }
}
