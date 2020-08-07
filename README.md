# Taller-I-Scripting-Nicolas-Escobar-Espinosa-000366591
Taller número 1 de scripting 2020 en el segundo semestre académico

Hola, en este documento se van a enunciar los componenetes que utilicé para la construcción y diseño del encargo.

Clase Skill
La clase skill posee lo ya pedido dentro de su enunciado de diseño, es abstracta por ende no se debe referir a ella si no a sus hijos.
  SuportSkill: Clase hija de skill que hereda todos los datos de su padre, pero no utilzia el generador random para su power, dado que ella no requiere poder para utilizarse, por   cuestiones del ejercico se crearon tres dentro del GameManager, Growth(atackUp), Barrier(defenseUp), Sticky Web(speedDown).
  AttackSkill: Clase hija de skill que hereda todos los datos de su padre, pero utiliza un generador random para su poder para inflinjir daño a su adversario, por cuestiones del     ejercicio se crearon dos dentro del GameManager, Afinity Beam, Afinity Punch.
  
Clase Critter
La clase critter posee lo ya pedido dentro de su enunciado de diseño, es abstracta dado que no vas a poseer un algo llamado critter, vas a tener millones (en nuestro caso solo seis, uno por elemento) de critters, para el ejercico se crearon clases hijas de critter para poder hacer el calcúlo de afinidades mucho mas facíl.
  Smeltoad: Critter de Fuego
  Surfleece: Critter de Agua
  Grizleaf: Critter de Tierra
  Monargle: Critter de Aire
  Paladight: Critter de Luz
  Shadowl: Critter de Oscuridad
Todos lo critters heredan los métodos de su padre, pero cada uno altera o sobreescribe el método de calculo de afinidad que su padre le hereda.
La clase critter y cada critter recibén el daño ademas ellos mismo calculán su valor.
Los critters aprenden sus skill en un método que se enuncia o debe enunciar cada vez que se inicializan, en mi caso dicho método está en game manager llamado "Start Game"

Clase Player
Clase que solamente posee un nombre y una lista de critters, dicha lista es modulable pero para iniciar se construye con tres critters a su elección, el tiene el método encargado de perder y ganar critters cuando el GameManager da la orden

GameManager
El GameManager es donde todas las simulaciones tienen lugar, dentro se solucionan y ejemplifican todas las interacciones. Si alguien con ams tiempo toma el ejercicio debe saber que el game manager posee la condición de perder critters o ganarlos, en nuestro caso se ejemplifica solo con el jugador "gary" perdiendo un critter "Paladight" a manos del jugador "ash", la condición del metodo se basa en simular un ataque continuo de "Surfleece" contra "Paladight", hasta que este se quede sin vida para poder combatir.

Program
Para probar y calificar la solución de los puntos en el programa se ordena utilizar y compilar el Program.cs, dentro estan todos los métodos del game manager quepermitén comenzar.
  
