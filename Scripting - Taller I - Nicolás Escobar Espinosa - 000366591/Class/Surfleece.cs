using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //esta habilidad hereda toda la información de su padre, salvo dos detalles que son alterados al recibirlos
    class Surfleece : Critter
    {
        //se instancian los constructores tanto vacios como llenos del proyecto
        public Surfleece() : base()
        {

        }

        public Surfleece(string name) : base(name)
        {
            if (name.Equals(null))
                this.name = "Surfleece";
            else
                this.name = name;

            afinity = "Water";

        }

        public override float AfinityMultiplier(String attackerCritterAfinity)
        {
            float afinityMultiplier = 0;

            if (attackerCritterAfinity.Equals("Dark") || attackerCritterAfinity.Equals("Light") || attackerCritterAfinity.Equals("Earth"))
            {
                afinityMultiplier = 1;
            }
            else if (attackerCritterAfinity.Equals("Fire"))
            {
                afinityMultiplier = 2;
            }
            else if (attackerCritterAfinity.Equals("Wind") || attackerCritterAfinity.Equals("Water"))
            {
                afinityMultiplier = 0.5f;
            }

            return afinityMultiplier;
        }
    }
}
