using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    class Player
    {
        //Se crean los datos del jugador
        private string name;

        //Se crea una lista modificable de criters que posee el jugador
        private List<Critter> critters = new List<Critter>();

        //Se crea el construcctor vació que se ejecuta al inicio
        public Player()
        {
            name = "";
            critters.Clear();
        }

        //Se crea el construcctor lleno que se ejecuta al inciar su instancia
        public Player(String name, Critter firstCritter, Critter secondCritter, Critter thirdCritter)
        {
            this.name = name;
            critters.Add(firstCritter);
            critters.Add(secondCritter);
            critters.Add(thirdCritter);
        }

        //Se crea un accesor que delimite la entrada de datos del jugador
        internal List<Critter> Critters { get => critters; set => critters = value; }
        public string Name { get => name; set => name = value; }

        public string loseCritter(Critter critter)
        {
            if (critter.Hp <= 0)
            {
                critters.Remove(critter);
                return (name + " a perdido un critter " + critter.Name);
            }
            else
                return ("El critter aun puede continuar ");
        }

        public string winCritter(Critter critter)
        {
            critters.Add(critter);
            return (name + " a ganado el critter " + critter.Name);
        }
    }
}
