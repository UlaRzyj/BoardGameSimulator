namespace BoardGameSimulator.Classes;

public class Player
{
    public string Name { get; }
    public static int Position { get; set; }
    public static int Score { get; set; }
    private Random rnd = new Random();
    public string[] Type = ["Warrior", "Wizard", "Healer"];
    public static string PlayerType { get; set; }

    public Player(string name)
    {
        Name = name;
        Position = 0;
        Score = 0;
        var Random = rnd.Next(0, 2);
        PlayerType = Type[Random];
        Game.Players.Add(this);
        
        Game.Add(this);
    }

    public void MoveOnBoard()
    {
        Random rnd = new Random();
        var cube = rnd.Next(1, 6);
        Position += cube;

        
        
        
    }
    
    public void UpdateScore()
    {
        
    }
}