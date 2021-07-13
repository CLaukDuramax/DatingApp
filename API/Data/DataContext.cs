using System;
using Microsoft.EntityFrameworkCore;
using API.Entities;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
	}
}
