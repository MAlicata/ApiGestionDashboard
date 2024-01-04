using System.Reflection.PortableExecutable;
using TechOil.DataAccess.Repositories;

namespace TechOil.Services
{
    public interface IUnitOfWork : IDisposable
    {
        public UsuarioRepository UsuarioRepository { get;}
        Task<int> Complete();
    }
}
