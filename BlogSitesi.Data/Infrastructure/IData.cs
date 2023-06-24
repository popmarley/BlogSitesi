using BlogSitesi.Data.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Data.Infrastructure
{
	public interface IData<T>
	{
		DataResult Insert(T t);
		DataResult Update(T t);
		DataResult Delete(T t);
		DataResult DeleteByKey(int id);

		T GetbyKey(int id);

		List<T> GetAll();
		List<T> GetAll(string orderBy,bool isDesc=false);
		List<T> GetBy(Expression<Func<T, bool>> predicate);
		List<T> GetBy(Expression<Func<T, bool>> predicate, string orderBy, bool isDesc = false);
		List<T> GetByPage(int pageNumber, int pageCount, string orderBy="ID", bool isDesc = false);
		List<T> GetByPage(Expression<Func<T, bool>> predicate, int pageNumber, int pageCount, string orderBy = "ID", bool isDesc = false);

		T FirstOrDefault(Expression<Func<T, bool>> predicate, bool asNoTracking =false);
		T FirstOrDefault(Expression<Func<T, bool>> predicate, string orderBy = "ID", bool isDesc = false, bool asNoTracking = false);

		void DetachAllEntities();

		DataResult InsertBulk(List<T> ts, bool validateAndIgnoreBefore =false);

		int GetCount();
		int GetCount(Expression<Func<T, bool>> predicate);
	}
}
