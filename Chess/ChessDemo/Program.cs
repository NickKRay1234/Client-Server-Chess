namespace ChessDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Chess.Chess chess = new Chess.Chess();
        while (true)
        {
            Console.WriteLine(chess.fen);
            string? move = Console.ReadLine();
            if(move == "") break;
            chess.Move(move);
        }
    }
}