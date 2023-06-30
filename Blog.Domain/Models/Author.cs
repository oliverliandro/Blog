using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Models;

public class Author
{
	public Author(string name)
	{
		Name = name;
		Posts = new List<News >();
	}

	public int Id { get; }
	public string Name { get; private set; }
	public IList<News> Posts { get; private set; }

}
