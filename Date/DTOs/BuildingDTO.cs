using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date.DTOs
{
    public class BuildingDTO
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        [Required(ErrorMessage = "SellerCorner field is required")]
        public string SellerCorner { get; set; }
        [Required(ErrorMessage = "Area field is required")]
        public string Area { get; set; }
        [Required(ErrorMessage = "PostCode field is required")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Address field is required")]
        public string Address { get; set; }
        public int? IdFunUnfun { get; set; }
        public int? IdTenures { get; set; }
        [Required(ErrorMessage = "Badrooms field is required")]
        public int Badrooms { get; set; }
        [Required(ErrorMessage = "Bathrooms field is required")]
        public int Bathrooms { get; set; }
        [Required(ErrorMessage = "Living rooms field is required")]
        public int Livingrooms { get; set; }
        [Required(ErrorMessage = "Property Status field is required")]
        public string PropertyStatus { get; set; }
        public bool SSTC { get; set; }
        public bool Garden { get; set; }
        public bool Parking { get; set; }
        [Required(ErrorMessage = "Shower state is required")]
        public bool Shower { get; set; }
        public bool IsItSell { get; set; }
        [Required(ErrorMessage = "Price is a required field")]
        [Range(1, double.MaxValue, ErrorMessage = "Price must be more than 1")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string TenureValue { get; set; }
        public string FurnishedValue { get; set; }
        public string MainPhoto { get; set; }

        public virtual IEnumerable<BuildingPhotoDTO> BuildingPhotos { get; set; }
    }
}
