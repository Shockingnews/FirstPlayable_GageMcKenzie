using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal abstract class Character
    {
        public HealthSystem _health;
        public string _name;
        public Position _pos;
        public Character(int health, string name, int PosY, int PosX)
        {
            _health = new HealthSystem(health);
            _name = name;
            _pos.x = PosX;
            _pos.y = PosY;
        }
        

        
    }
}
