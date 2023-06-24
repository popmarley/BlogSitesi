using BlogSitesi.Data.Infrastructure;
using BlogSitesi.Data.Infrastructure.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Data
{
	public class ContentCategoryData : EntityBaseData<Model.ContentCategory>
	{
		public ContentCategoryData(IOptions<Connection> dbOptions)
			: base(new DataContext(dbOptions.Value.ConnectionString))
		{

		}
	}
}
