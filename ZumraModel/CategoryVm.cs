using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumraModel
{
    public class CategoryVm
    {
        public int ID { get; set; }
        public string TitleEN { get; set; }
        public string DescriptionEN { get; set; }
        public string TitleAR { get; set; }
        public string DescriptionAR { get; set; }
        public string IMG { get; set; }
        public string Tags { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CDate { get; set; }
        public int CUser { get; set; }

        public List<ProductVm> Products { get; set; }
    }
}
