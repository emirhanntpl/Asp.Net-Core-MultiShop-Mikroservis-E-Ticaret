using System;

public interface IRepository<T> where T : class
{
	Task<List<T>> GetAllAsync();
	Task<T> GetByIdAsync();
	Task<T> CreateAsync();
	Task<T> DeleteAsync();
	Task<T> UpdateAsync();
	Task<T> GetByFilterAsync(Expression<Func<T, bool>>, filter);
	


	
}
