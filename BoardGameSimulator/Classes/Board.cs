namespace BoardGameSimulator.Classes;

public class Board
{
    public int Size { get; }
    public static int[] SpecialField { get; set; }
    public int Fields { get; set; }
    private Random rnd = new Random();
    public static int Prize = 5;

    public Board(int size)
    {
        Size = size;
        int Fields = rnd.Next(1, Size);
        SpecialField = new int[Fields];
    }

    public void randomPrize()
    {
        for(var i=0; i<=Fields; i++)
        {
            int randomField = rnd.Next(1, Size);
            SpecialField[i] = randomField;
        }
    }
}