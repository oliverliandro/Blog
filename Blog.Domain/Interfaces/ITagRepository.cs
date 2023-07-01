using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Interfaces;

public interface ITagRepository
{
	Task<IEnumerable<Tag>> GetAllAsync();
	Task<Tag>GetTagByIdAsync(int id);
	Task<Tag> AddAuthorAsync(Tag tag);
	Task DeleteAuthorAsync(Tag tag);
	Task UpdateAutorAsync(Tag tag);
}
