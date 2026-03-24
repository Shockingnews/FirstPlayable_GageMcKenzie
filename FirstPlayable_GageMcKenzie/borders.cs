using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class Borders
    {
        Player _player;
        List<Enemy> _enmies;
        public List<(int, int, string)> borders = new List<(int, int,string)>();
        public Borders(Player player, List<Enemy> enmies)
        {
            _player = player;
            _enmies = enmies;
            
        }

        public void AddBorders()
        {
            borders.Add((20, 20, "Left"));
            borders.Add((22, 20, "Left"));
            borders.Add((21, 19, "Top"));
            borders.Add((21, 21, "Top"));
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
                for (int i = 0; i < borders.Count(); i++)
                {
                    Console.SetCursorPosition(borders[i].Item1, borders[i].Item2);
                    if (borders[i].Item3 == "Left")
                    {
                        Console.Write(LeftBorder());
                    }
                    else
                    {
                        Console.Write(TopBorder());
                    }
                }
                //Console.SetCursorPosition(borders[0].Item1, borders[0].Item2);
                //Console.Write(LeftBorder());
                //Console.SetCursorPosition(borders[1].Item1, borders[1].Item2);
                //Console.Write(RightBorder());
                //Console.SetCursorPosition(borders[2].Item1, borders[2].Item2);
                //Console.Write(TopBorder());
                //Console.SetCursorPosition(borders[3].Item1, borders[3].Item2);
                //Console.Write(BottemBorder());
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
