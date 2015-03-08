using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date.DTOs
{
    public class BuildingPhotoDTO
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int IdBuilding { get; set; }
        public string Description { get; set; }
        public BuildingPhotoDTO() { }
    }
}
