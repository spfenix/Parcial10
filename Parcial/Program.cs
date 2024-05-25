public class Program
{
    static int[,] tablero = new int[0 , 0]; 
    static int posX = 0, posY = 0;
    static bool escKeyPressed = false;

    private static void Main(string[] args)
    {
        Iniciartablero();
        ShowTablero();
        ShowMenu();
    }
    private static void ShowMenu()
    {
        while (!escKeyPressed)
        {
            ConsoleKeyInfo keyPressed; 

            Console.WriteLine("Use las teclas de dirección para mover la 'O', o presione la tecla 'ESC' para salir");
            Console.WriteLine("Pulse Flecha Derecha");
            Console.WriteLine("Pulse Flecha Izquierda");
            Console.WriteLine("Pulse Flecha Arriba");
            Console.WriteLine("Pulse Flecha Abajo");
            Console.WriteLine("Pulse Esc para Salir");
            keyPressed = Console.ReadKey();
            switch (keyPressed.Key)
            {
                case ConsoleKey.RightArrow:
                    Move0("derecha");
                    break;
                case ConsoleKey.LeftArrow:
                    Move0("izquierda");
                    break;
                case ConsoleKey.UpArrow:
                    Move0("arriba");
                    break;
                case ConsoleKey.DownArrow:
                    Move0("abajo");
                    break;
                case ConsoleKey.Escape:
                    escKeyPressed = true;
                    break;

            }
       