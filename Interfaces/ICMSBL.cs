using Date.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICMSBL
    {
        void CreateCMS(Date.DTOs.CMSPageDTO entity);
        void UpdateCMS(int id, Date.DTOs.CMSPageDTO entity);
        void DeleteCMS(int id);
        List<CMSPageViewModel> GetCMS();
    }
}
