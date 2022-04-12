abstract public class Plant 
{
    public int Growth {get; set;}
    public int GrowthLimit {get; protected set;}
    public int PropogateAt {get; protected set;}

    public Coord[] PropogateCoords {get; protected set;}
    public Coord Position {get; set;}
    public string[] ?SymbolList {get; protected set;}
    public ConsoleColor[] ?ColorList {get; protected set;}

    public Plant(string[] symbolList, ConsoleColor[] colorList, Coord[] propogateCoords, int propogateAt, int growthLimit) 
    {
        SymbolList = symbolList;
        ColorList = colorList;
        PropogateCoords = propogateCoords;
        PropogateAt = propogateAt; //If -1 it never propogates
        GrowthLimit = growthLimit;
    }

    public abstract void Update();

    public abstract Plant[] PlantFactory();

}