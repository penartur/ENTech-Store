namespace ENTech.Store.Entities
{
	public interface IQuery<in TCriteria, out TResult>
		where TCriteria : IQueryCriteria
	{
		TResult Execute(IDbContext dbContext, TCriteria criteria);
	}
}