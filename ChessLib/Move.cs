namespace ChessLib;

public class Move
{
    private readonly Square _from;
    private readonly Square _to;

    public Move(int from, int to) : this(new Square(from), new Square(to))
    {
    }

    public Move(string from, string to)
    {
        _from = new Square(from);
        _to = new Square(to);
    }

    public Move(Square from, Square to)
    {
        _from = from;
        _to = to;
    }

    public Square From => _from;
    public Square To => _to;


    public override string ToString()
    {
        return _from.ToString() + _to.ToString();
    }
}