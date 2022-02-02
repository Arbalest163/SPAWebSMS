using Microsoft.EntityFrameworkCore;
using SPAWebSMS.Domain;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;

namespace SPAWebSMS.Application.Interfaces
{
    public interface ISPAWebSMSDbContext
    {
        DbSet<Message> Messages { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry Entry([NotNullAttribute] object entity);
    }
}
