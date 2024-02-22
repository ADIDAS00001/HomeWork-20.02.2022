namespace task3;

public class Player
{
    public string? Name;
    public int Number;
    public string? Position;
    public string? Team;
    public void ScoreGoal()
    {
        System.Console.WriteLine($"Name: {Name} scores a goal.");
    }
    public void AssistGoal(string playername) 
    {
        System.Console.WriteLine($"Player {Name} assists a goal for {playername}.");
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}");
    }

}
