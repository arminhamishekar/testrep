using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using پروژه_حل_نمرین_جلسه_سوم.Models.Blog;
using پروژه_حل_نمرین_جلسه_سوم.Models.Products;
using پروژه_حل_نمرین_جلسه_سوم.Services.Interfaces;

namespace پروژه_حل_نمرین_جلسه_سوم.Services.Implementations
{
    public class BlogService : IBlogInterface, IGeneralInterface<BlogModel>
    {
        public void AddComment(string comment)
        {
            throw new NotImplementedException();
        }
        #region Custom Methods
        public void AddItem(BlogModel Add)
        {

        }
        public void EditITem(BlogModel Edit)
        {

        }

        public void RemoveItem(BlogModel Remove)
        {

        }
        #endregion
    }
}
