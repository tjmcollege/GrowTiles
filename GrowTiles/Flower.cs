public class Flower : Plant
{
    public Flower(Coord position, int growth) : base(new string[] {".","i","@"}, 
    new ConsoleColor[] {ConsoleColor.Green, ConsoleColor.DarkGreen, ConsoleColor.Red}, 
    new Coord[] {new Coord(1,0), new Coord(0,1), new Coord(0,-1), new Coord(-1,0)}, 2, 2)
    {
        Position = position;
        Growth = growth;
    }
    
    public override void Update() 
    {
        if (Growth == GrowthLimit)
            Growth = 2;
        else
            Growth++;
    }
    public override Plant[] PlantFactory()
    {
        Plant[] newPlantList = new Plant[PropogateCoords.Length];

        for (int i = 0; i < PropogateCoords.Length; i++) 
        {
            Coord newPosition = CoordUtils.Add(Position,PropogateCoords[i]);
            newPlantList[i] = new Flower(newPosition,0);
        }

        return newPlantList;
    }
}