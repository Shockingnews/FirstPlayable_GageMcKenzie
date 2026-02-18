using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal abstract class Character
    {
        public HealthSystem maxHealth;
        public HealthSystem maxShield;
        
        public Character(int health, int shield)
        {
            maxHealth = new HealthSystem(health);
            maxShield = new HealthSystem(shield);

        }

        public virtual void TakeDamage(int chooseDamage)
        {

            maxHealth.health -= chooseDamage;
        }
        //public void Update()
        //{
        //    GetHealthSystem();
        //}

        //public void GetHealthSystem(HealthSystem healthSystem)
        //{

        //}



    }
}
