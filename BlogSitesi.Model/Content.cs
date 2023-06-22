using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model
{
	public class Content : Core.ModelBase
	{
        public Content()
        {
            IsActive = false;
			IsDeleted = false;
			CreateDate = DateTime.Now;
			UpdateDate = DateTime.Now;
			PublishDate = DateTime.Now;
        }

        public int MediaID { get; set; }
        public string Title { get; set; }
		public string MetaTitle { get; set; }
		public string MetaDescription { get; set; }
		public string Description { get; set; }
		public string Slug { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public DateTime PublishDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }



        public virtual Media Media { get; set; }
        public virtual List<ContentCategory>ContentCategories { get; set; }
        public virtual List<ContentTag>ContentTags { get; set; }
    }
}
