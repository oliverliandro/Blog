using Blog.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.IoC
{
	public static  class DependencyInjection
	{
		public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<BlogContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("MyConnection"),
				b => b.MigrationsAssembly(typeof(BlogContext).Assembly.FullName));
			});

			return services;
		}
	}
}
