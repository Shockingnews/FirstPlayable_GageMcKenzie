using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GageMcKenzie
{
    internal abstract class Character
    {
        public HealthSystem _systemHealth;
        
        public Character(int health)
        {
            _systemHealth = new HealthSystem(health);
            
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
