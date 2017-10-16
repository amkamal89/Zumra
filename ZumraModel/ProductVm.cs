using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumraModel
{
    public class ProductVm
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string TitleEN { get; set; }
        public string TitleAR { get; set; }
        public string ShortDescriptionEN { get; set; }
        public string ShortDescriptionAR { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionAR { get; set; }
        public string Tags { get; set; }
        public string[] TagsList { get; set; }
        public string UPC { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public string IMG { get; set; }
        public int? AttachmentID { get; set; }
        public bool InStock { get; set; }
        public int NoInStock { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CDate { get; set; }
        public int CUser { get; set; }
    }
}
