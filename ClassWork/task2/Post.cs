namespace task2;
public class Post
{
    public string? Text;
    public int Likes;
    public List<string> Comments= new List<string>();
    public void SetPost(string text)
    {
        Text=text;
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Tetx = {Text}\nLikes : {Likes}");
    }

}
