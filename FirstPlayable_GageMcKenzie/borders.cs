using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Borders
    {
        Player _player;
        List<Enemy> _enmies;
        public List<(int, int)> borders = new List<(int, int)>();
        public Borders(Player player, List<Enemy> enmies)
        {
            _player = player;
            _enmies = enmies;
            
        }

        public void AddBorders()
        {
            borders.Add((20, 20));
        }

        public void UpdateBorder()
        {
            if (borders.Count() > 0)
            {
                if (_player.currentPos.x == borders[0].Item1 && _player.currentPos.y == borders[0].Item2)
                {
                    _player.PreviousPos();
                }
                if (_enmies[0]._enemyPos.x == borders[0].Item1 && _enmies[0]._enemyPos.y == borders[0].Item2)
                {
                    _enmies[0].PrePos();
                }
            }

        }

        public void DrawBorder()
        {
            if(borders.Count() > 0)
            {
                Console.SetCursorPosition(borders[0].Item1, borders[0].Item2);
                Console.Write(LeftBorder());
            }
            
        }

        public char LeftBorder()
        {
            
            return '|';
        }
        public char RightBorder()
        {
            return '|';
        }
        public char TopBorder()
        {
            return '-';
        }
        public char BottemBorder()
        {
            return '-';
        }
    }
}
