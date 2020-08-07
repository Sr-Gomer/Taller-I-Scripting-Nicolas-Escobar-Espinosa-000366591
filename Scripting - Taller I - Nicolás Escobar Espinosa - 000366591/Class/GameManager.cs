using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //Se crea una clase game manager que controla toda interacción entre el jugador o los critters dentro
    class GameManager
    {
        static Grizleaf grizleaf = new Grizleaf("Grizleaf");
        static Monargle monargle = new Monargle("Monargle");
        static Paladight paladight = new Paladight("Paladight");
        static Shadowl shadowl = new Shadowl("Shadowl");
        static Smeltoad smeltoad = new Smeltoad("Smeltoad");
        static Surfleece surfleece = new Surfleece("Surfleece");

        Player ash = new Player("Ash", smeltoad, grizleaf, surfleece);
        Player gary = new Player("Gary", monargle, paladight, shadowl);

        public void startGame()
        {
            foreach (Critter critter in ash.Critters)
            {
                critter.learnSkils(critter);
            }

            foreach (Critter critter in gary.Critters)
            {
                critter.learnSkils(critter);
            }
        }

        //primer caso de uso y segundo
        public void firstAndSecond()
        {
            Console.WriteLine("\nEnunciado: Un AttackSkill NO puede crearse con poder 0, ni con un valor fuera del rango.");
            Console.WriteLine("Enunciado: Un SupportSkill NO puede crearse con poder superior a 0");

            foreach (Critter critter in ash.Critters)
            {
                Console.WriteLine("Name :" + critter.Name);
                Console.WriteLine("afinity :" + critter.Afinity);
                Console.WriteLine("\nMoveset: ");

                foreach (Skill skill in critter.Moveset)
                {
                    
                    Console.WriteLine("Name: " + skill.Name);
                    Console.WriteLine("Afinity: " + skill.Afinity);
                    Console.WriteLine("Power: " + skill.Power);
                }

                Console.WriteLine("\n-----------------------------------------------------------");

            }
        }

        //tercer caso de uso
        public void third()
        {
            Console.WriteLine("\nEnunciado: Tras aplicar por una única ocasión el skill SpdDown a un critter, el valor de su velocidad base se mantiene; pero sí hay un incremento en la velocidad del critter durante la pelea.");

            Console.WriteLine("\nInicio de combate");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Name + " va a recibir un speed down ");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Speed + " es su velocidad al comenzar");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").TemporalSpeed + " es su velocidad temporal al comenzar");

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").Name + " ataca a " + ash.Critters.Find(x => x.Name == "Surfleece").Name + " con " + ash.Critters.Find(x => x.Name == "Smeltoad").Moveset.Find(x => x.Name == "Sticky Web").Name);
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").receiveAttack(ash.Critters.Find(x => x.Name == "Smeltoad"), ash.Critters.Find(x => x.Name == "Smeltoad").Moveset.Find(x => x.Name == "Sticky Web")));

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Speed + " es su velocidad al terminar");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").TemporalSpeed + " es su velocidad temporal al terminar");

            Console.WriteLine("\n-----------------------------------------------------------");
        }

        //cuarto caso de uso
        public void fourth()
        {
            Console.WriteLine("\nTras aplicar 4 veces DefUp a un critter, la defensa del critter no puede reflejar un valor diferente al que tuviera tras la tercera aplicación del Skill.");

            Console.WriteLine("\nInicio de combate");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").Name + " va a recibir un defense Up");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").BaseDefense + " es su defensa al comenzar");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").TemporalDefense + " es su defensa temporal al comenzar");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").Name + " utiliza " + ash.Critters.Find(x => x.Name == "Smeltoad").Moveset.Find(x => x.Name == "Barrier").Name);
                Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").buffMyself(ash.Critters.Find(x => x.Name == "Smeltoad").Moveset.Find(x => x.Name == "Barrier")));

                Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").BaseDefense + " es su defensa al terminar");
                Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").TemporalDefense + " es su defensa temporal al terminar"); 
            }

            Console.WriteLine("\n-----------------------------------------------------------");
        }

        //quinto caso de uso
        public void fifth()
        {
            Console.WriteLine("\nEl daño recibido por un critter con afinidad Earth al ser atacado con un Skill de afinidad Fire debe ser 0 a través la fórmula especificada");

            Console.WriteLine("\nInicio de combate");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Grizleaf").Name + " va a recibir un ataque ");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Grizleaf").Hp + " es su vida al comenzar");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Grizleaf").Afinity + " es su afinidad");

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").Name + " va a atacar ");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").BaseAttack + " es su poder de ataque");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").Afinity + " es su afinidad");

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Smeltoad").Name + " utiliza " + ash.Critters.Find(x => x.Name == "Smeltoad").Moveset.Find(x => x.Name == "Afinity Beam").Name + " sobre " + ash.Critters.Find(x => x.Name == "Grizleaf").Name);
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Grizleaf").receiveAttack(ash.Critters.Find(x => x.Name == "Smeltoad"), ash.Critters.Find(x => x.Name == "Smeltoad").Moveset.Find(x => x.Name == "Afinity Beam")));

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Grizleaf").Name + " va a recibió un ataque");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Grizleaf").Hp + " es su vida al terminar");

            Console.WriteLine("\n-----------------------------------------------------------");
        }

        //sexto caso de uso
        public void sixth()
        {
            Console.WriteLine("\nEl daño recibido por un critter con afinidad Earth al ser atacado con un Skill de afinidad Fire debe ser 0 a través la fórmula especificada");

            Console.WriteLine("\nInicio de combate");
            Console.WriteLine(gary.Critters.Find(x => x.Name == "Monargle").Name + " va a recibir un ataque ");
            Console.WriteLine(gary.Critters.Find(x => x.Name == "Monargle").Hp + " es su vida al comenzar");
            Console.WriteLine(gary.Critters.Find(x => x.Name == "Monargle").Afinity + " es su afinidad");

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Name + " va a atacar ");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").BaseAttack + " es su poder de ataque");
            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Afinity + " es su afinidad");

            Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Name + " utiliza " + ash.Critters.Find(x => x.Name == "Surfleece").Moveset.Find(x => x.Name == "Afinity Punch").Name + " sobre " + gary.Critters.Find(x => x.Name == "Monargle").Name);
            Console.WriteLine(gary.Critters.Find(x => x.Name == "Monargle").receiveAttack(ash.Critters.Find(x => x.Name == "Surfleece"), ash.Critters.Find(x => x.Name == "Surfleece").Moveset.Find(x => x.Name == "Afinity Punch")));

            Console.WriteLine(gary.Critters.Find(x => x.Name == "Monargle").Name + " va a recibió un ataque");
            Console.WriteLine(gary.Critters.Find(x => x.Name == "Monargle").Hp + " es su vida al terminar");

            Console.WriteLine("\n-----------------------------------------------------------");
        }

        //Septimo caso de uso
        public void seventh()
        {
            while (gary.Critters.Find(x => x.Name == "Paladight").Hp > 0)
            {
                Console.WriteLine(ash.Critters.Find(x => x.Name == "Surfleece").Name + " utiliza " + ash.Critters.Find(x => x.Name == "Surfleece").Moveset.Find(x => x.Name == "Afinity Punch").Name + " sobre " + gary.Critters.Find(x => x.Name == "Paladight").Name);
                Console.WriteLine(gary.Critters.Find(x => x.Name == "Paladight").receiveAttack(ash.Critters.Find(x => x.Name == "Surfleece"), ash.Critters.Find(x => x.Name == "Surfleece").Moveset.Find(x => x.Name == "Afinity Punch")));
                Console.WriteLine(gary.Critters.Find(x => x.Name == "Paladight").Name + " tiene " + gary.Critters.Find(x => x.Name == "Paladight").Hp + " de vida");
            }

            foreach (Critter critter in gary.Critters)
            {
                if (critter.Hp < 0)
                {
                    Console.WriteLine(gary.loseCritter(critter));
                    Console.WriteLine(ash.winCritter(critter));
                    break;
                }
            }

            Console.WriteLine("\n-----------------------------------------------------------");
        }

    }
}
