using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Data.Infrastructure
{
	public static class DynamicOrderBy
	{
		public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property)
		{
			return ApplyOrder<T>(source, property, "OrderBy");
		}
		public static IOrderedQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string property)
		{
			return ApplyOrder<T>(source, property, "OrderByDescending");
		}
		public static IOrderedQueryable<T> ThenBy<T>(this IQueryable<T> source, string property)
		{
			return ApplyOrder<T>(source, property, "ThenBy");
		}
		public static IOrderedQueryable<T> ThenByDescending<T>(this IQueryable<T> source, string property)
		{
			return ApplyOrder<T>(source, property, "ThenByDescending");
		}

		static IOrderedQueryable<T> ApplyOrder<T>(this IQueryable<T> source, string property, string methodName)
		{
			string[] props = property.Split(',');
			Type type = typeof(T);
			ParameterExpression arg = Expression.Parameter(typeof(T), "x");
			Expression expr = arg;
			foreach (var prop in props)
			{
				PropertyInfo pi = type.GetProperty(prop);
				expr = Expression.Property(expr, pi);
				type = pi.PropertyType;
			}

			Type delagateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
			LambdaExpression lambda = Expression.Lambda(delagateType, expr, arg);

			object result = typeof(Queryable).GetMethods().Single(
			method => method.Name == methodName
			&& method.IsGenericMethodDefinition
			&& method.GetGenericArguments().Length == 2
			&& method.GetParameters().Length == 2)
			.MakeGenericMethod(typeof(T), type)
			.Invoke(null, new object[] { source, lambda });
			return (IOrderedQueryable<T>)result;


		}
	}
}
