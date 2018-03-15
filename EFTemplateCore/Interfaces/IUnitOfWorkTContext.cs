

namespace EFTemplateCore.Interfaces
{
    /// <summary>
    /// Defines the interface(s) for generic unit of work.
    /// </summary>
    public interface IUnitOfWork<TContext> : IBaseUnitOfWork where TContext : EFContext, new()
    {
        /// <summary>
        /// Gets the db context.
        /// </summary>
        /// <returns>The instance of type <typeparamref name="TContext"/>.</returns><
        TContext DbContext { get; }
    }
}
