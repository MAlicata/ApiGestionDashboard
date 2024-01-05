using System.Reflection.PortableExecutable;
using ApiGestionDashboard.DataAccess.Repositories;

namespace ApiGestionDashboard.Services
{
    public interface IUnitOfWork : IDisposable
    {
        public UsuarioRepository UsuarioRepository { get;}
        Task<int> Complete();
    }
}
