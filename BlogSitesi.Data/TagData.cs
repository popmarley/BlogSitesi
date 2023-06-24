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
	public class TagData : EntityBaseData<Model.Tag>
	{
		public TagData(IOptions<Connection> dbOptions)
			: base(new DataContext(dbOptions.Value.ConnectionString))
		{

		}
	}
}
