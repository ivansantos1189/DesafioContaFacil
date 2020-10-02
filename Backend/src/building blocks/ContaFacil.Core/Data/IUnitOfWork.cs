using System.Threading.Tasks;

namespace ContaFacil.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}