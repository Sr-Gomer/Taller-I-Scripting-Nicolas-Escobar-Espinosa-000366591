using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //esta habilidad hereda toda la información de su padre, salvo dos detalles que son alterados al recibirlos
    class Smeltoad : Critter
    {
        //se instancian los constructores tanto vacios como llenos del proyecto
        public Smeltoad() : base()
        {

        }

        public Smeltoad(string name) : base(name)
        {
            if (name.Equals(null))
                this.name = "Smeltoad";
            else
                this.name = name;

            afinity = "Fire";
        }
        public override float AfinityMultiplier(String attackerCritterAfinity)
        {
            float afinityMultiplier = 0;

            if (attackerCritterAfinity.Equals("Dark") || attackerCritterAfinity.Equals("Light") || attackerCritterAfinity.Equals("Wind") || attackerCritterAfinity.Equals("Earth"))
            {
                afinityMultiplier = 1;
            }
            else if (attackerCritterAfinity.Equals("Fire") || attackerCritterAfinity.Equals("Water"))
            {
                afinityMultiplier = 0.5f;
            }

            return afinityMultiplier;
        }
    }
}
