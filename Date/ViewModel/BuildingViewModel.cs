using Date.DTOs;
using Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date.ViewModel
{
    public class BuildingViewModel : BuildingDTO
    {
        public string GardenVM;
        public string ParkingVM;
        public string ShowerVM;
        public BuildingViewModel() { }
        public BuildingViewModel(BuildingDTO newObj)
        {
            if (newObj == null)
            {
                return;
            }
            this.Address = newObj.Address;
            this.Area = newObj.Area;
            this.Badrooms = newObj.Badrooms;
            this.Bathrooms = newObj.Bathrooms;
            if (newObj.BuildingPhotos != null)
                this.BuildingPhotos = newObj.BuildingPhotos.Select(s => new BuildingPhotoViewModel()
                    {
                        Id = s.Id,
                        IdBuilding = s.IdBuilding,
                        FileName = s.FileName,
                        Description = s.Description
                    }).ToList<BuildingPhotoViewModel>();
            else
                this.BuildingPhotos = new List<BuildingPhotoViewModel>();
            this.GardenVM = (newObj.Garden) ? WebSiteResources.DetailsYes : WebSiteResources.DetailsNo;
            this.Garden = newObj.Garden;
            this.Id = newObj.Id;
            this.IdFunUnfun = newObj.IdFunUnfun;
            this.IdTenures = newObj.IdTenures;
            this.IsItSell = newObj.IsItSell;
            this.Livingrooms = newObj.Livingrooms;
            this.LongDescription = newObj.LongDescription;
            this.ParkingVM = newObj.Parking ? WebSiteResources.DetailsYes : WebSiteResources.DetailsNo;
            this.Parking = newObj.Parking;
            this.PostCode = newObj.PostCode;
            this.Price = newObj.Price;
            this.PropertyStatus = newObj.PropertyStatus;
            this.SellerCorner = newObj.SellerCorner;
            this.ShortDescription = newObj.ShortDescription;
            this.ShowerVM = newObj.Shower ? WebSiteResources.DetailsYes : WebSiteResources.DetailsNo;
            this.Shower = newObj.Shower;
            this.SSTC = newObj.SSTC;
            this.TenureValue = newObj.TenureValue;
            this.MainPhoto = newObj.MainPhoto;
            this.FurnishedValue = newObj.FurnishedValue;
        }
        public IEnumerable<string> GetPhotos()
        {
            return this.BuildingPhotos.Select(p => p.FileName);
        }
    }
}
