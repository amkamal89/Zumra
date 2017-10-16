using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZumraModel;
using ZumraData;

namespace ZumraService
{
    public class CategoryService
    {
        private readonly ZumraCRCEntities db;
        public CategoryService()
        {
            db = new ZumraCRCEntities();
        }

        public List<CategoryVm> CategoryList(int Count)
        {
            var Model = new List<CategoryVm>();
            try
            {
                Model = (from ct in db.Categories.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ID).Take(Count)
                         select new CategoryVm()
                         {
                             ID = ct.ID,
                             TitleAR = ct.TitleAR,
                             DescriptionAR = ct.DescriptionAR,
                             TitleEN = ct.TitleEN,
                             DescriptionEN = ct.DescriptionEN,
                             Tags = ct.Tags,
                             IMG = ct.IMG,
                             IsActive = ct.IsActive,
                             IsDeleted = ct.IsDeleted,
                             CDate = ct.CDate,
                             CUser = ct.CUser,
                         }).ToList();
            }
            catch (Exception ex)
            {

            }
            return Model;
        }
        public CategoryVm ProductsByCategoyID(int ID)
        {
            var Model = new CategoryVm();
            try
            {
                Model = (from ct in db.Categories.Where(a => a.IsDeleted == false && a.IsActive == true)
                         select new CategoryVm()
                         {
                             ID = ct.ID,
                             TitleAR = ct.TitleAR,
                             DescriptionAR = ct.DescriptionAR,
                             TitleEN = ct.TitleEN,
                             DescriptionEN = ct.DescriptionEN,
                             Tags = ct.Tags,
                             IMG = ct.IMG,
                             IsActive = ct.IsActive,
                             IsDeleted = ct.IsDeleted,
                             CDate = ct.CDate,
                             CUser = ct.CUser,
                         }).FirstOrDefault();
                if (Model.ID > 0)
                {
                    Model.Products = (from pr in db.Products.Where(a => a.IsActive == true && a.IsDeleted == false)
                                      select new ProductVm()
                                      {
                                          ID = pr.ID,
                                          CategoryID = pr.CategoryID,
                                          TitleEN = pr.TitleEN,
                                          TitleAR = pr.TitleAR,
                                          ShortDescriptionEN = pr.ShortDescriptionEN,
                                          ShortDescriptionAR = pr.ShortDescriptionAR,
                                          DescriptionEN = pr.DescriptionEN,
                                          DescriptionAR = pr.DescriptionAR,
                                          Tags = pr.Tags,
                                          SKU = pr.SKU,
                                          UPC = pr.UPC,
                                          Price = pr.Price,
                                          SalePrice = pr.SalePrice,
                                          AttachmentID = pr.AttachmentID,
                                          InStock = pr.InStock,
                                          NoInStock = pr.NoInStock,
                                          Notes = pr.Notes,
                                          IsActive = pr.IsActive,
                                          IsDeleted = pr.IsDeleted,
                                          CDate = pr.CDate,
                                          CUser = pr.CUser
                                      }).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return Model;
        }
    }
}
