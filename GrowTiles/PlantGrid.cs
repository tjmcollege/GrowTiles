public class PlantGrid 
{

    public int Columns {get; init;}
    public int Rows {get; init;}

    public List<Plant> PropogationsBuffer {get; private set;} = new List<Plant>();

    public Plant[,] Grid {get; private set;}

    public PlantGrid(int columns, int rows) 
    {
        Columns = columns;
        Rows = rows;

        Grid = CreateGrassGrid(columns, rows);
    }


    public Plant[,] CreateGrassGrid(int columns, int rows)
    {
        Plant[,] grid = new Plant[columns,rows];
        
        for(int i = 0; i < columns; i++) 
        {
            for(int j = 0; j < rows; j++) 
            {
                grid[i,j] = new Grass(new Coord(i,j),0);
            }
        }

        return grid;
    }

    public void SpreadPlants() 
    {
        for(int i = 0; i < Columns; i++) 
        {
            for(int j = 0; j < Rows; j++) 
            {
                if (Grid[i,j].PropogateAt == Grid[i,j].Growth) 
                {
                    foreach (Plant plant in Grid[i,j].PlantFactory()) 
                    {
                        PropogationsBuffer.Add(plant);
                    }   
                }
            }
        }
    }

    public void AddPlants()
    {   
        //Console.WriteLine(PropogationsBuffer.Count);
        foreach(Plant plant in PropogationsBuffer) 
        {
            if (plant.Position.Column < 0 || plant.Position.Row < 0 || plant.Position.Column >= Columns || plant.Position.Row >= Rows)
                //Console.WriteLine("Plant out of bounds");
                Console.Write(""); //Required for the if statements to work; if cannot be empty
            else 
            {
                if (Grid[plant.Position.Column,plant.Position.Row].GetType() == plant.GetType())
                    //Console.WriteLine("Plant overgrow");
                    Console.Write("");
                else
                    Grid[plant.Position.Column,plant.Position.Row] = plant;
            }
        }
        PropogationsBuffer.Clear();
    }

    public void DisplayGrid() 
    {
        for(int i = 0; i < Columns; i++) 
        {
            for(int j = 0; j < Rows; j++) 
            {
                Console.ForegroundColor = Grid[i,j].ColorList[Grid[i,j].Growth];
                Console.Write(Grid[i,j].SymbolList[Grid[i,j].Growth]);
            }
            Console.WriteLine();
        }
    }

    public void Update() 
    {
        for(int i = 0; i < Columns; i++) 
        {
            for(int j = 0; j < Rows; j++) 
            {
                Grid[i,j].Update();
            }
        }
        SpreadPlants();
        AddPlants();
    }
}