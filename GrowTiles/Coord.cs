public struct Coord 
{
    public int Column {get; init;}
    public int Row {get; init;}

    public Coord(int column, int row) 
    {
        Column = column;
        Row = row;
    }

    public override string ToString() 
    {
        return (Column + "," + Row);
    }
}