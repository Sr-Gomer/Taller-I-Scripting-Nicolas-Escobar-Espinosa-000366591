using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591.Class;

namespace Scripting___Taller_I___Nicolás_Escobar_Espinosa___000366591
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            gameManager.startGame();
            gameManager.firstAndSecond();
            gameManager.third();
            gameManager.fourth();
            gameManager.fifth();
            gameManager.sixth();
            gameManager.seventh();
        }
    }
}
