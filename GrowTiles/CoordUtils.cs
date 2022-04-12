public static class CoordUtils 
{
    public static Coord Add(Coord p1, Coord p2) 
    {
        return new Coord(p1.Column + p2.Column, p1.Row + p2.Row);
    }
}