



using task3;

var student = new Student ();
student.Name="Muhammad Samadov";
student.GrandLevel=11;
student.TestScores=new double[5]{100,90,90,100,90};
System.Console.WriteLine("-----------------------");


var average=student.GetAverage(); 
if(average>=85)
{
    System.Console.WriteLine($"Congratulations {student.Name} on achieving above average scores ({average}) in grade {student.GrandLevel}! Keep up the good work!");
}
else if(average>=70 && average<85)
{
    System.Console.WriteLine($"{student.Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {average} in grade {student.GrandLevel}.");
}
else
{
    System.Console.WriteLine("vi ne proshli kurs");
}