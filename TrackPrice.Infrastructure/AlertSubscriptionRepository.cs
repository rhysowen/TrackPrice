using System.Linq.Expressions;
using TrackPrice.Domain.Entities;
using TrackPrice.Domain.Repositories;

namespace TrackPrice.Infrastructure;

public class AlertSubscriptionRepository : IAlertSubscriptionRepository
{
    public Task<AlertSubscription> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<AlertSubscription>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<AlertSubscription>> FindAsync(Expression<Func<AlertSubscription, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<AlertSubscription> SingleOrDefaultAsync(Expression<Func<AlertSubscription, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(AlertSubscription entity)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(IEnumerable<AlertSubscription> entities)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(AlertSubscription entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeAsync(IEnumerable<AlertSubscription> entities)
    {
        throw new NotImplementedException();
    }
}