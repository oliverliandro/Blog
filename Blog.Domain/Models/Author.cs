using System;
using System.Collections.Generic;

namespace Blog.Domain.Models;

public class Author
{
	public int Id { get; }
	public string Name { get; private set; }
	public IList<News> Posts { get; private set; }

}
