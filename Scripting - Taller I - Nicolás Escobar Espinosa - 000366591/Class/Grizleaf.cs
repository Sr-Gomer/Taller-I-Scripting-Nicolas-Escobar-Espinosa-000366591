using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //esta habilidad hereda toda la información de su padre, salvo dos detalles que son alterados al recibirlos
    class Grizleaf : Critter
    {
        //se instancian los constructores tanto vacios como llenos del proyecto
        public Grizleaf() : base()
        {

        }

        public Grizleaf(string name) : base(name)
        {
            if (name.Equals(null))
                this.name = "Grizleaf";
            else 
                this.name = name;

            afinity = "Earth";
        }

        public override float AfinityMultiplier(String attackerCritterAfinity)
        {
            float afinityMultiplier = 0;

            if (attackerCritterAfinity.Equals("Dark") || attackerCritterAfinity.Equals("Light") || attackerCritterAfinity.Equals("Water"))
            {
                afinityMultiplier = 1;
            }
            else if (attackerCritterAfinity.Equals("Fire"))
            {
                afinityMultiplier = 0;
            }
            else if (attackerCritterAfinity.Equals("Earth") || attackerCritterAfinity.Equals("Wind"))
            {
                afinityMultiplier = 0.5f;
            }

            return afinityMultiplier;
        }
    }
}
