using System.Linq;
using  Data.Entity;
using  GenericRepository.Interfaces;

namespace DomainService.Abstraction
{
    public interface IUserRepository:IGenericRepository<Users>
    {
        Users GetSingle(int id);

        IQueryable<Users> MySearch(Users model);
    }
}
