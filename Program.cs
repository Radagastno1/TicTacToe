internal class Program
{
    public static string field;

    private static void Main(string[] args)
    {
        //starta spelet
        StartGame();
    }

    private static void StartGame()
    {
        while (true)
        {
            Player player1 = new();
            Player player2 = new();
            player1.SquaresChosen.Add(1);
            player1.Symbol = "X";
            RenderField(player1, player2);
            Console.ReadLine();
            break;
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


}
