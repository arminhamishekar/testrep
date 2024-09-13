using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using پروژه_حل_نمرین_جلسه_سوم.Models.Products;
using پروژه_حل_نمرین_جلسه_سوم.Services.Interfaces;

namespace پروژه_حل_نمرین_جلسه_سوم.Services.Implementations
{
    internal class ProductService : IProductInterface , IGeneralInterface<ProductModel>
    {
        #region custom method
        
        public void BuyProduct(int id)
        {
            //Buy product
        }
        public void AddToFavorite(int productid)
        {
            //Add To Favorite
        }
        #endregion

        #region Generic Methods 
        public void AddItem(ProductModel Add)
        {
    
        }
        public void EditITem(ProductModel Edit)
        {
    
        }

        public void RemoveItem(ProductModel Remove)
        {
    
        }
        #endregion
    }
}
