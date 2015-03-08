using Date.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date.ViewModel
{
    public class CMSTypeViewModel : CMSTypeDTO
    {
        public bool Current { get; set; }
        public CMSTypeViewModel() { }
        public CMSTypeViewModel(CMSTypeDTO cms)
        {
            this.Id = cms.Id;
            this.IdUsers = cms.IdUsers;
            this.TypeName = cms.TypeName;
            Current = false;
        }
    }
}
