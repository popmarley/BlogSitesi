using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model
{
	public class ContentTag : Core.ModelBase
	{
		public ContentTag(int contentID, int tagID)
		{
			TagID = tagID;
			ContentID = contentID;
		}

		public int ContentID { get; set; }
		public int TagID { get; set; }

	}
	
	
}
