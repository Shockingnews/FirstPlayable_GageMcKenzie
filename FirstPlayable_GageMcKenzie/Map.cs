using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Map
    {
        static string _mapData = @"MapFile.txt";
        string[] _newMapDate = File.ReadAllLines(_mapData);
        Player _player;
        Enemy _enemy;
        public Map(Player player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void PrintMap()
        {
            Console.Write(_newMapDate.ToString());
        }
    }
}
