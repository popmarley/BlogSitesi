using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Data.Infrastructure
{
	public class BoolToIntConverter:ValueConverter <bool,int>
	{
		public BoolToIntConverter(ConverterMappingHints mappingHints=null)
			: base(
				  v=> Convert.ToInt32(v),
				  v=> Convert.ToBoolean(v),
				  mappingHints)
		{ }

		public static ValueConverterInfo DefaultInfo { get; }
		= new ValueConverterInfo(typeof(bool),typeof(int),i=> new BoolToIntConverter(i.MappingHints));
	}
}
