using Date.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICMSTypeRepository
    {
        void CreateCMS(Date.DTOs.CMSTypeDTO entity);
        void UpdateCMS(int id, Date.DTOs.CMSTypeDTO entity);
        void DeleteCMS(int id);
        List<CMSTypeViewModel> GetCMS();
    }
}
