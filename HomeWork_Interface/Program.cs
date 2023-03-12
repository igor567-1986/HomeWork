House house = new House();
Team team = new Team();

Console.WriteLine(team.Name);

Random rand = new Random();

for (int i = 0; i < 6; i++)
{
    team.workers[rand.Next(0, 3)].Build(house, team. lider);
}

foreach (var a in team.lider.report)
{
    Console.WriteLine(a);
}

team.   lider.Report();
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    team.workers[rand.Next(0, 3)].Build(house, team.lider);
}

foreach (var a in team.lider.report)
{
    Console.WriteLine(a);
}
team.lider.Report();

house.Paint(team.lider);
Console.ReadKey();


interface IWorker
{
    string Name { get; }
}
interface IPart
{
    void Part(House house);
}

class House
{
    public Basement basement;
    public List<Walls> walls;
    public List<Window> window;
    public Door door;
    public Roof roof;
    public void Paint(TeamLeader t)
    {
        if (t.report.Count == 11)
        {

            string domik = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

            Console.WriteLine(domik);
        }
        else Console.WriteLine("The house is not built yet");
    }
}


class Basement : IPart
{
    public void Part(House house)
    {
        house.basement = new Basement();
    }
}
class Walls : IPart
{
    public void Part(House house)
    {
        house.walls.Add(new Walls());
    }
}
class Door : IPart
{
    public void Part(House house)
    {
        house.door = new Door();
    }
}
class Window : IPart
{
    public void Part(House house)
    {
        house.window.Add(new Window());
    }
}

class Roof : IPart
{
    public void Part(House house)
    {
        house.roof = new Roof();
    }
}
class Team : IWorker
{
    public TeamLeader lider;
    public List<Worker> workers;
    public string Name { get => "ООО Теремок"; }
    public Team()
    {
        lider = new TeamLeader("Ахмет");
        workers = new List<Worker> { new Worker ("Равшан"), new Worker ("Джамшут"), new Worker ("Ахмат") };
    }
}
class Worker : IWorker
{
    string Name { get; set; }
    string IWorker.Name => Name;
    public Worker(string name)
    {
        Name = name;
    }
    public void Build(House house,TeamLeader lider)
    {
        if(house.basement==null)
        {
            Basement basement= new Basement();
            basement.Part(house);
            lider.report.Add($"Строитель {Name} построил фундамент!");
        }
        else if (house.walls==null||house.walls.Count <4)
        {
            if (house.walls == null) house.walls = new List<Walls>();
            Walls walls= new Walls();
            walls.Part(house);
            lider.report.Add($"Строитель {Name} построил стену {house.walls.Count}!");
        }
        else if (house.door == null)
        {
            Door door= new Door();
            door.Part(house);
            lider.report.Add($"Строитель {Name} построил дверь");
        }
        else if (house.window==null || house.window.Count<4)
        {
            if(house.window==null) house.window = new List<Window>();
            Window window= new Window();
            window.Part(house);
            lider.report.Add($"Строитель {Name} вставил {house.window.Count} окно");                                                                                                                   
        }
        else if (house.roof == null)
        {
            Roof roof = new Roof();
            roof.Part(house);
            lider.report.Add($"Строитель {Name} построил крышу!");
        }
    }
}
class TeamLeader : IWorker
{
    string Name { get; set; }
    public List<string> report = new List<string>();
    string IWorker.Name => Name;

    public TeamLeader(string name)
    { Name = name; }
    public void Report()
    {
        double percent = (report.Count / 11.0) * 100;
        Console.WriteLine($"Строительство завершено на {(int)percent} % ");
    }
}
