using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstPlayable_GageMcKenzie
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Player player = new Player(new HealthSystem(100), new HealthSystem(50), "Gage", 0, new Position(0, 0));
            player.Position();

        }

    }
}
