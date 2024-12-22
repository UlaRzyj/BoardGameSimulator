namespace BoardGameSimulator.Classes;

public interface Type
{
    void TypePrize();
}
public class Prize : Type
{
    private Random rnd = new Random();
    public void TypePrize()
    {
        if (Player.PlayerType == "Warrior")
        {
            var NumberOfPlayers = Game.Players.Count - 1; 
            var random = rnd.Next(0, NumberOfPlayers);
            var randomPlayer = Game.Players[random];
            Game.Players[random]. -= 3;
            Player.Score += 3;
        }
        else if (Player.PlayerType == "Wizard")
        {
            Player.Position += 3;
        }
        else if (Player.PlayerType == "Healer")
        {
            var NumberOfPlayers = Game.Players.Count - 1; 
            var random = rnd.Next(0, NumberOfPlayers);
            var person = Game.Players[random];
            person.Score += rnd.Next(0, 5);
        }
        
        
    }
}