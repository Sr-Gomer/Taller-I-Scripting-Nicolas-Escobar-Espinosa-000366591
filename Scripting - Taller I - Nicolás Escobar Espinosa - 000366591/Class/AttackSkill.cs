using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //esta habilidad hereda toda la información de su padre, salvo dos detalles que son alterados al recibirlos
    class AttackSkill : Skill
    {

        //Se crean los constructores que se requieren para el flujo normal del juego
        public AttackSkill() : base()
        {
         
        }
        public AttackSkill(Critter critterOwner, string name) : base(critterOwner, name)
        {
            this.name = name;
            afinity = critterOwner.Afinity;
            power = random.Next(0, 10);
        }

    }
}
