using System;

namespace DullStarData.Repositories
{
    public interface IUserRepository
    {
        void CreateUser(string Id, string UserName, DateTime BirthDate);
        
        }
}