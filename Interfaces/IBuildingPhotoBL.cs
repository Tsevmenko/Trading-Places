using Date.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBuildingPhotoBL
    {
        void CreateBuildingPhoto(Date.DTOs.BuildingPhotoDTO entity);
        void UpdateBuildingPhoto(int id, Date.DTOs.BuildingPhotoDTO entity);
        void DeleteBuildingPhoto(int id);
        List<BuildingPhotoViewModel> GetBuildingPhotos(int id);
        BuildingPhotoViewModel GetPhotoById(int id);
    }
}
