using Date.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBuildingBL
    {
        void CreateBuilding(Date.DTOs.BuildingDTO entity);
        void UpdateBuilding(int id, Date.DTOs.BuildingDTO entity);
        void DeleteBuilding(int id);
        IEnumerable<BuildingViewModel> GetBuildings();
        BuildingViewModel GetBuildingById(int id);
    }
}
