using BlogSitesi.Data.Infrastructure;
using BlogSitesi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Data
{
	public class DataContext : DbContext
	{
		public DataContext(string connectionString) : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentCategory> ContentCategories { get; set; }
        public DbSet<ContentTag> ContentTags { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Setting> Setting { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Author>(entity => entity.ToTable("Authors"));
			builder.Entity<Category>(entity => entity.ToTable("Categories"));
			builder.Entity<Comments>(entity => entity.ToTable("Comments"));
			builder.Entity<Content>(entity => entity.ToTable("Contents"));
			builder.Entity<ContentCategory>(entity => entity.ToTable("Content_Categories"));
			builder.Entity<ContentTag>(entity => entity.ToTable("Content_Tags"));
			builder.Entity<Media>(entity => entity.ToTable("Medias"));
			builder.Entity<Tag>(entity => entity.ToTable("Tags"));
			builder.Entity<Setting>(entity => entity.ToTable("Setting"));

			foreach(var entityType in builder.Model.GetEntityTypes())
			{
				foreach(var property in entityType.GetProperties())
				{
					if (property.ClrType == typeof(bool))
					{
						property.SetValueConverter(new BoolToIntConverter());
					}
				}
			}
		}
	}
}
