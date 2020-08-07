using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class
{
    //Se crea una clase abstracta dado que se van a crear una cantidad básica de critters que heredan de esta mas, no requieren acceder a esta
    abstract class Critter
    {
        //Se crean las estadisticas basicas del critter que son asignadas al momento de instanciar 
        protected string name, afinity;
        protected int baseAttack, baseDefense, speed;
        protected float hp, temporalAttack, temporalDefense, temporalSpeed;
        protected Random random = new Random();

        protected int bufAtkCounter, bufDefCounter, debufSpdCounter;

        //Se crean el compendio de clases que requiere un critter
        private List<Skill> moveset = new List<Skill>();

        //Se crean los constructores necesarios para instanciar el juego, uno tanto vacio y otro con los requerimentos
        protected Critter(string name)
        {
            this.name = name;

            baseAttack = random.Next(10, 101);
            baseDefense = random.Next(10, 101);
            speed = random.Next(10, 51);
            hp = 1000;

            temporalAttack = baseAttack;
            temporalDefense = baseDefense;
            temporalSpeed = speed;

            bufAtkCounter = 0;
            bufDefCounter = 0;
            debufSpdCounter = 0;
        }

        protected Critter()
        {
            name = "";
            afinity = "";

            baseAttack = 0;
            baseDefense = 0;
            speed = 0;
            hp = 0;

            temporalAttack = baseAttack;
            temporalDefense = baseAttack;
            temporalSpeed = speed;

            moveset.Clear();

            bufAtkCounter = 0;
            bufDefCounter = 0;
            debufSpdCounter = 0;
        }

        public string Name { get => name;}
        public string Afinity { get => afinity;}
        public float BaseAttack { get => baseAttack;}
        public float BaseDefense { get => baseDefense;}
        public float Speed { get => speed;}
        public float Hp { get => hp; set => hp = value; }
        public float TemporalAttack { get => temporalAttack; set => temporalAttack = value; }
        public float TemporalDefense { get => temporalDefense; set => temporalDefense = value; }
        public float TemporalSpeed { get => temporalSpeed; set => temporalSpeed = value; }
        internal List<Skill> Moveset { get => moveset; }

        //se crean el compendio de métodos que realiza un critter
        public string receiveAttack(Critter attackingCritter, Skill attackingSkill)
        {
            if (attackingSkill.Power > 0)
            {
                float damageValue = (attackingCritter.TemporalAttack + attackingSkill.Power) * AfinityMultiplier(attackingCritter.Afinity);
                Hp -= damageValue;
                return (Name + " Recive " + damageValue + " de daño por " + attackingCritter.Name);
            }
            else if (attackingSkill.Power == 0)
            {
                if (attackingSkill.Name.Equals("Sticky Web") && debufSpdCounter < 3)
                {
                    debufSpdCounter += 1;
                    float debuf = (speed * 30) / 100;
                    temporalSpeed -= debuf;

                    return (Name + " Recive " + debuf + " menos a su velocidad, ahora tiene " + temporalSpeed + " de velocidad");
                }
                else
                {
                    return "Obejtivo no valido para el ataque";
                }
            }
            return "";
        }

        public string buffMyself(Skill buffSkill)
        {
            if (buffSkill.Power == 0)
            {
                if (buffSkill.Name.Equals("Growth") && bufAtkCounter < 3)
                {
                    bufAtkCounter += 1;
                    float buf = (baseAttack * 20) / 100;
                    temporalAttack += buf;

                    return (Name + " Recive " + buf + " mas a su ataque , ahora tiene " + temporalAttack + " de ataque");
                }
                else if(buffSkill.Name.Equals("Barrier") && bufDefCounter < 3)
                {
                    bufDefCounter += 1;
                    float buf = (baseDefense * 20) / 100;
                    temporalDefense += buf;

                    return (Name + " Recive " + buf + " mas a su defensa , ahora tiene " + temporalDefense + " de defensa");
                }
                else
                {
                    return "Obejtivo no valido para el ataque";
                }
            }
            else
            {
                return "Habilidad no valida para el utilizarse";
            }
        }

        public virtual float AfinityMultiplier(String attackerCritterAfinity)
        {
            float afinityMultiplier = 0;

            return afinityMultiplier;
        }
        
        public void learnSkils(Critter critterStudent)
        {
            SupportSkill growth = new SupportSkill(critterStudent, "Growth");
            critterStudent.moveset.Add(growth);
            
            SupportSkill barrier = new SupportSkill(critterStudent, "Barrier");
            critterStudent.moveset.Add(barrier);
           
            SupportSkill stickyWeb = new SupportSkill(critterStudent, "Sticky Web");
            critterStudent.moveset.Add(stickyWeb);

            AttackSkill afinityBeam = new AttackSkill(critterStudent, "Afinity Beam");
            critterStudent.moveset.Add(afinityBeam);

            AttackSkill afinityPunch = new AttackSkill(critterStudent, "Afinity Punch");
            critterStudent.moveset.Add(afinityPunch);
        }
    }
}
