// See https://aka.ms/new-console-template for more information

//Programa de manejo de ciclos 
//ID: 11

String message = "";
String SwitchControl = "Menu", controlcarta = "";
System.Random random = new System.Random();

//Juego Blackjack, juntar 21 pidiendo cartas en caso de tener menos
//Refactorizacion de ciclos while En C#
while (true)
{
    int totalJugador = 0, num = 0;
    var totalDealer = 0;
    switch (SwitchControl)
    {
        case "Menu":
            Console.WriteLine("Bienvenido al casino");
            Console.WriteLine("Escriba 21, para jugar 21");
            SwitchControl = Console.ReadLine();
            break;
        case "21":
            Console.WriteLine("Hola, Bienvenido a la consola de Blackjack");

            do
            {
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("Toma tu carta Jugador");
                Console.WriteLine($"Te salio el numero: {num} ");
                Console.WriteLine("Deseas Otra Carta??");

                controlcarta = Console.ReadLine();

            } while (controlcarta == "Si" || controlcarta == "si");

            totalDealer = random.Next(14, 23);
            Console.WriteLine($"El total Dealer tiene: {totalDealer}");
            if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al Dealer, felicidades";
                SwitchControl = "Menu";
            }
            else if (totalJugador > 21)
            {
                message = "Perdiste vs Dealer, te pasaste de 21";
                SwitchControl = "Menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = "Perdiste vs el Dealer, lo siento";
                SwitchControl = "Menu";
            }
            else
            {
                message = "Condición no valida";
                SwitchControl = "Menu";
            }

            Console.WriteLine("El resultado es: " + message);
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}