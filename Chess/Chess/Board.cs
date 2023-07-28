namespace Chess;

public class Board
{
    public string fen { get; private set; }
    private Figure[,] _figures;
    public Color moveColor { get; private set; }
    public int moveNumber { get; private set; }


    public Board(string fen)
    {
        this.fen = fen;
        _figures = new Figure[8, 8];
        Init();
    }

    private void Init()
    {
        SetFigureAt(new Square("a1"), Figure.whiteKing);
        SetFigureAt(new Square("h8"), Figure.blackKing);
        moveColor = Color.white;
    }

    public Figure GetFigureAt(Square square) =>
        square.OnBoard() ? _figures[square.x, square.y] : Figure.none;

    public void SetFigureAt(Square square, Figure figure)
    {
        if (square.OnBoard())
            _figures[square.x, square.y] = figure;
    }

    public Board Move(FigureMoving fm)
    {
        Board next = new Board(fen);
        next.SetFigureAt(fm.from, Figure.none);
        next.SetFigureAt(fm.to, fm.promotion == Figure.none? fm.figure : fm.promotion);
        if (moveColor == Color.black) next.moveNumber++;
        next.moveColor = moveColor.FlipColor();
        return next;
    }
}