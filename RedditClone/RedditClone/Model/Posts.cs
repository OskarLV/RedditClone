namespace RedditClone.Model;

public class Posts
{
    //Tom constructor som EF skal bruge
    public Posts() {}
    
    
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Votes { get; set; }
    public string Content { get; set; }
    public List<Comments> Comments { get; set; } = new List<Comments>();
}