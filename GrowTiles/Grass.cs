public class Grass : Plant
{
    public Grass(Coord position, int growth) : base(new string[] {"m","n"}, 
    new ConsoleColor[] {ConsoleColor.DarkGreen, ConsoleColor.Green}, new Coord[] {}, -1, 1)
    {
        Position = position;
        Growth = growth;
    }

    public override void Update() 
    {
        if (Growth == GrowthLimit)
            Growth = 0;
        else
            Growth++;
    }
    public override Plant[] PlantFactory()
    {
        return new Plant[0];
        throw new NotImplementedException();
    }
}