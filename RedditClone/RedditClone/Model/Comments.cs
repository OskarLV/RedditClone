namespace RedditClone.Model;

public class Comments
{
    public int CommentId { get; set; }
    public string Author { get; set; }
    public int Votes { get; set; }
    public DateTime CreateTime { get; set; }
    
}