using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Date.DTOs
{
    public class CMSPageDTO
    {
        public int Id { get; set; }
        public int IdCMSType { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public string PageTitle { get; set; }
    }
}
