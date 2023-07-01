using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Models;

public class News
{

	public int Id { get;}
	public string Title { get; private set; }
    public string Subject { get; private set; }
    public string Content { get; private set; }
	public DateTime PublicationDate { get; private set; }
	public IList<Tag> Tags { get; private set; }
	public Author Author { get; private set; }
	
}
