using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal class HealthSystem
    {
        public int health;
        public HealthSystem(int Health)
        {
            health = Health;
        }
        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        

    }
}
