using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model.Core
{
	public class IgnoredAttribute:System.Attribute
	{
        public string SomeProperty { get; set; }
    }
}
