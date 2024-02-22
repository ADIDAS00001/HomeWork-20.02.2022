namespace task3;

public class Student
{
    public string? Name;
    public int GrandLevel;
    public double[]? TestScores;
    public double GetAverage()
    {
        double sum=0;
        foreach (var item in TestScores)
        {
            sum+=item;
        }
        return sum/(double) TestScores.Length;
    }
   
}

