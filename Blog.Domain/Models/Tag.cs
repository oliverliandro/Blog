using System.Collections.Generic;

namespace Blog.Domain.Models;

public class Tag
{
	public int Id { get; }
	public string TagName { get; private set; }
    public IList<News> Posts { get; }
}