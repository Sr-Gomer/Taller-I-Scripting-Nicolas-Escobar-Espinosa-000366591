using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //Se crea una clase abstracta dado que se van a crear una cantidad básica de habilidades de esta, mas no requieren acceder a esta
    abstract class Skill 
    {
        //Se crean las estadisticas basicas de la habilidad que son asignadas al momento de instanciar 
        protected string name, afinity;
        protected int power;
        protected Random random = new Random();

        //Se crean los constructores que se requieren para el flujo normal del juego
        protected Skill()
        {
            name = "";
            afinity = "";
            power = 0;
        }
        protected Skill(Critter critterOwner, string name)
        {
            this.name = name;
            afinity = critterOwner.Afinity;
            power = random.Next(0,10);
        }

        //Se crea un accesor que delimite la entrada de datos del jugador
        public string Name { get => name;}
        public string Afinity { get => afinity;}
        public int Power { get => power;}
    }
}
