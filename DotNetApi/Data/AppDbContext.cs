using DotNetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<ToDo> ToDos => Set<ToDo>();
}