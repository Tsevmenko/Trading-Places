using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITenureRepository
    {
        void CreateTenure(Date.DTOs.TenureDTO entity);
        void UpdateTenure(int id, Date.DTOs.TenureDTO entity);
        void DeleteTenure(int id);
        List<Date.DTOs.TenureDTO> GetTenures();
    }
}
