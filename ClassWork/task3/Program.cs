



using task3;

var player= new Player();
System.Console.Write("Enter player's name: ");
player.Name=Console.ReadLine();
System.Console.Write("Enter player's number: ");
player.Number=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter player's position: ");
player.Position=Console.ReadLine();
System.Console.Write("Enter player's team: ");
player.Team=Console.ReadLine();
player.GetInfo();
player.ScoreGoal();
player.AssistGoal("Taliska");

