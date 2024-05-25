
public class Program
{
    //VARIABLES GLOBALES
    static int[,] tablero = new int[0, 0];
    static int posX = 0, posY = 0;
    static bool escKeyPressed = false;

     
   
    static void Main(string[] args)
    {
        IniciarTablero();
        ShowTablero();
        ShowMenu();

    }

    private static void ShowMenu()
    {
        while (!escKeyPressed)
        {
            ConsoleKeyInfo keyPressed; //Así declaro una variable para almacenar la tecla que pulsé

            Console.WriteLine("Use las teclas de dirección para mover y ganar puntos, o presione la tecla 'ESC' para salir");
            Console.WriteLine("Pulse Flecha Derecha o la tecla D");
            Console.WriteLine("Pulse Flecha Izquierda  o la tecla A ");
            Console.WriteLine("Pulse Flecha Arriba  o la tecla W");
            Console.WriteLine("Pulse Flecha Abajo  o la tecla S");
            Console.WriteLine("Pulse Esc para Salir");
            keyPressed = Console.ReadKey(); //ReadKey para leer la tecla pulsada

            switch (keyPressed.Key)
            {
                case ConsoleKey.RightArrow:
                    MoveO("derecha");
                    break;
                case ConsoleKey.LeftArrow:
                    MoveO("izquierda");
                    break;
                case ConsoleKey.UpArrow:
                    MoveO("arriba");
                    break;
                case ConsoleKey.DownArrow:
                    MoveO("abajo");
                    break;
                case ConsoleKey.Escape:
                    escKeyPressed = true;
                    break;
            }

            ShowBoard();
        }
    }

    private static void MoveO(string direction)
    {
        board[posX, posY] = 'X'; //Estoy sobreescribiendo la O por la X en la posición inicial [0,0]

        switch (direction)
        {
            case "derecha":
                if (posY < 4) posY++;
                break;

            case "izquierda":
                if (posY > 0) posY--;
                break;

            case "arriba":
                if (posX > 0) posX--;
                break;

            case "abajo":
                if (posX < 4) posX++;
                break;
        }

        board[posX, posY] = 'O';
    }

    private static void ShowBoard()
    {
        Console.Clear();
        Console.WriteLine("Mueva la bolita!\n");
        for (int f = 0; f < 5; f++)
        {
            for (int c = 0; c < 5; c++)
                Console.Write(board[f, c] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void InitializeBoard()
    {
        //Aquí lleno mi tablero
        for (int f = 0; f < 5; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                board[f, c] = 'X';
            }
        }

        board[posX, posY] = 'O';
    }
}