using EKino.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EKino.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<EKinoApplicationUser> GetAll();
        EKinoApplicationUser Get(string id);
        void Insert(EKinoApplicationUser entity);
        void Update(EKinoApplicationUser entity);
        void Delete(EKinoApplicationUser entity);
    }
}
