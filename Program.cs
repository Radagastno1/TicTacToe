internal class Program
{
    public static string field;
    public static int turn = 1;

    public static Dictionary<ConsoleKey, int> keysAndNumbers =
        new()
        {
            { ConsoleKey.D1, 1 },
            { ConsoleKey.D2, 2 },
            { ConsoleKey.D3, 3 },
            { ConsoleKey.D4, 4 },
            { ConsoleKey.D5, 5 },
            { ConsoleKey.D6, 6 },
            { ConsoleKey.D7, 7 },
            { ConsoleKey.D8, 8 },
            { ConsoleKey.D9, 9 }
        };

    private static void Main(string[] args)
    {
        //starta spelet
        StartGame();
    }

    private static void StartGame()
    {
        Player player1 = new();
        player1.Symbol = "X";

        Player player2 = new();
        player2.Symbol = "O";

        while (true)
        {
            RenderField(player1, player2);
            PlayerChoosesSquare(player1, player2);
            IsPlayerWinning(player1, player2);
        }
    }

    private static void RenderField(Player player1, Player player2)
    {
        string square1 = player1.SquaresChosen.Any(s => s == 1)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 1)
                ? player2.Symbol
                : " ";
        string square2 = player1.SquaresChosen.Any(s => s == 2)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 2)
                ? player2.Symbol
                : " ";
        string square3 = player1.SquaresChosen.Any(s => s == 3)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 3)
                ? player2.Symbol
                : " ";
        string square4 = player1.SquaresChosen.Any(s => s == 4)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 4)
                ? player2.Symbol
                : " ";
        string square5 = player1.SquaresChosen.Any(s => s == 5)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 5)
                ? player2.Symbol
                : " ";
        string square6 = player1.SquaresChosen.Any(s => s == 6)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 6)
                ? player2.Symbol
                : " ";
        string square7 = player1.SquaresChosen.Any(s => s == 7)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 7)
                ? player2.Symbol
                : " ";
        string square8 = player1.SquaresChosen.Any(s => s == 8)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 8)
                ? player2.Symbol
                : " ";
        string square9 = player1.SquaresChosen.Any(s => s == 9)
            ? player1.Symbol
            : player2.SquaresChosen.Any(s => s == 9)
                ? player2.Symbol
                : " ";

        Console.WriteLine("      |       |       ");
        Console.WriteLine($"   {square1}  |   {square2}   |   {square3}  ");
        Console.WriteLine($"---------------------");
        Console.WriteLine("      |       |       ");
        Console.WriteLine($"   {square4}  |   {square5}   |   {square6}  ");
        Console.WriteLine($"---------------------");
        Console.WriteLine("      |       |       ");
        Console.WriteLine($"   {square7}  |   {square8}   |   {square9}  ");
    }

    private static void PlayerChoosesSquare(Player player1, Player player2)
    {
        if (turn % 2 != 0)
        {
            Console.WriteLine("Player 1 with symbol X, go! Please choose square (1-9).");

            ConsoleKey keyChosen = Console.ReadKey().Key;

            AddSquareNumberToPlayersList(player1, keyChosen);
        }
        else
        {
            Console.WriteLine("Player 2 with symbol O is up! Please choose square (1-9).");
            ConsoleKey keyChosen = Console.ReadKey().Key;

            AddSquareNumberToPlayersList(player2, keyChosen);
        }
        turn++;
    }

    private static void AddSquareNumberToPlayersList(Player player, ConsoleKey keyChosen)
    {
        int squareNr = 0;
        string keyAsString = string.Empty;

        if (keysAndNumbers.Any(k => k.Key == keyChosen))
        {
            keyAsString = keyChosen.ToString();
            string keyWithOnlyNumber = keyAsString[1].ToString();
            Console.WriteLine("key with only nr: " + keyWithOnlyNumber);
            int.TryParse(keyWithOnlyNumber, out squareNr);
            player.SquaresChosen.Add(squareNr);
        }
    }

    private static void IsPlayerWinning(Player player1, Player player2)
    {
        if (
            player1.SquaresChosen.Contains(1)
                && player1.SquaresChosen.Contains(2)
                && player1.SquaresChosen.Contains(3)
            || player1.SquaresChosen.Contains(1)
                && player1.SquaresChosen.Contains(4)
                && player1.SquaresChosen.Contains(7)
            || player1.SquaresChosen.Contains(1)
                && player1.SquaresChosen.Contains(5)
                && player1.SquaresChosen.Contains(9)
            || player1.SquaresChosen.Contains(3)
                && player1.SquaresChosen.Contains(6)
                && player1.SquaresChosen.Contains(9)
            || player1.SquaresChosen.Contains(7)
                && player1.SquaresChosen.Contains(8)
                && player1.SquaresChosen.Contains(9)
        )
        {
            RenderField(player1, player2);
            Console.WriteLine("Player 1 is a winner!");
            Environment.Exit(0);
        }
        else if (
            player2.SquaresChosen.Contains(1)
                && player2.SquaresChosen.Contains(2)
                && player2.SquaresChosen.Contains(3)
            || player2.SquaresChosen.Contains(1)
                && player2.SquaresChosen.Contains(4)
                && player2.SquaresChosen.Contains(7)
            || player2.SquaresChosen.Contains(1)
                && player2.SquaresChosen.Contains(5)
                && player2.SquaresChosen.Contains(9)
            || player2.SquaresChosen.Contains(3)
                && player2.SquaresChosen.Contains(6)
                && player2.SquaresChosen.Contains(9)
            || player2.SquaresChosen.Contains(7)
                && player2.SquaresChosen.Contains(8)
                && player2.SquaresChosen.Contains(9)
        )
        {
            RenderField(player1, player2);
            Console.WriteLine("Player 2 is a winner!");
            Environment.Exit(0);
        }
    }
}
