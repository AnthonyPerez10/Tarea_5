// See https://aka.ms/new-console-template for more information

//Programa de Uso de ciclos for
//ID: 11

//Añadi de igual forma el video 19 soluciones y errores. 
int totalJugador = 0, num = 0;
var totalDealer = 0;
String message = "";
String SwitchControl = "Menu", controlcarta = "";
System.Random random = new System.Random();
int creditos = 0;
//Juego Blackjack, juntar 21 pidiendo cartas en caso de tener menos

while (true)
{
    Console.WriteLine("Bienvenido al casino");
    Console.WriteLine("Cuanto creditos deseas:\n " +
        "Ingresa un numero Entero.\n" +
        "######## Recuerda que necesitas una por ronda. ########");
    creditos = int.Parse(Console.ReadLine());

    for (int i = 0; i < creditos; i++)
    {
        totalJugador = 0;
        num = 0;
        totalDealer = 0;
        switch (SwitchControl)
        {
            case "Menu":
                Console.WriteLine("Escriba 21, para jugar 21");
                SwitchControl = Console.ReadLine();
                //Hacer que nos cobre un credito al entrar a menu
                i = i - 1;
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

                    //Incluyendo la clase del video 17 = Factorizacion del codigo
                    controlcarta = Console.ReadLine();

                } while (controlcarta == "Si" || controlcarta == "si");

                totalDealer = random.Next(12, 23);
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
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}
