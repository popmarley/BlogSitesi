using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model
{
	public class ContentCategory:Core.ModelBase
	{
        public ContentCategory(int contentID, int categoryID)
        {
            CategoryID = categoryID;
            ContentID = contentID;
        }

        public int ContentID { get; set; }
        public int CategoryID { get; set; }

    }
}
