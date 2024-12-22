using System.Net.Sockets;

namespace BoardGameSimulator.Classes;

public class Game
{
    private Random rnd = new Random();
    public static List<Player> Players { get; set; }
    //delegat

    public static void Add(Player person)
    {
        Players.Add(person);
    }
    
    public void startGame()
    {
        
    }

    public void Check()
    {
        Prize prize = new Prize();
        foreach (var Field in Board.SpecialField)
        {
            if (Player.Position == Field)
            {
                prize.TypePrize();
            }
        }
    }
    
    public void endGame()
    {
        
    }
}