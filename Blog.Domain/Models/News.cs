using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Models;

public class News
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public string Content { get; set; }
	public DateTime PublicationDate { get; set; }
	public IList<Tag> Tags { get; set; }
	public Author Author { get; set; }
}
