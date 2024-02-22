


using task2;

var post = new Post();
post.Text="It is Post";
post.AddLike();
post.AddLike();
post.AddLike();
post.AddLike();
post.AddLike();
post.AddLike();
post.AddComment("Super");
post.AddComment($"Great\n");
post.GetInfo();
System.Console.WriteLine($"Comments : {post.Comments.Count}");
foreach (var item in post.Comments)
{
    System.Console.WriteLine(item);
}
