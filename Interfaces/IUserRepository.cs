using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserRepository
    {
        void CreateUser(Date.DTOs.UserDTO entity);
        void UpdateUser(int id, Date.DTOs.UserDTO entity);
        void DeleteUser(int id);
        List<Date.DTOs.UserDTO> GetUser();
    }
}
