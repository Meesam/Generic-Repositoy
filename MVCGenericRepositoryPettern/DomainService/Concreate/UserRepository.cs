using System.Linq;
using Data.Entity;
using  Data.Context;
using  GenericRepository.Implimentation;
using  DomainService.Abstraction;

namespace DomainService.Concreate
{
    public class UserRepository:GenericRepository<UserEntities,Users>,IUserRepository
    {
        public Users GetSingle(int id)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == id);
            return query;
        }

        public IQueryable<Users> MySearch(Users model)
        {
            var query = from u in Context.Users.Where(x => x.FirstName == model.FirstName)
                select u;
            return query;
        }
    }
}
