using Date.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFurnishedRepository
    {
        void CreateFurnished(FurnishedViewModel entity);
        void UpdateFurnished(int id, FurnishedViewModel entity);
        void DeleteFurnished(int id);
        List<FurnishedViewModel> GetFurnished();
    }
}
