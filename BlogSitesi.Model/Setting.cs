using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model
{
	public class Setting : Core.ModelBase
	{
		public string LogoPath { get; set; }
		public string HomeMetaTitle { get; set; }
		public string HomeMetaDescription { get; set; }
		public string FtpUserName { get; set; }
		public string FtpPassword { get; set; }
		public string FtpSiteUrl { get; set; }
		public string MediaBasePath { get; set; }
		
	
	}
}
