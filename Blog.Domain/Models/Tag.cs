namespace Blog.Domain.Models;

public class Tag
{
	public Tag(string tagName)
	{
		TagName = tagName;
		Posts = new List<News>();
	}

	public int Id { get; }
	public string TagName { get; private set; }
    public IList<News> Posts { get; }
}