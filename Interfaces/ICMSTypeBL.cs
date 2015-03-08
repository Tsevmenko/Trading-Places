using Date.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICMSTypeBL
    {
        void CreateCMSType(Date.DTOs.CMSTypeDTO entity);
        void UpdateCMSType(int id, Date.DTOs.CMSTypeDTO entity);
        void DeleteCMSType(int id);
        List<CMSTypeViewModel> GetCMSTypes();
    }
}
